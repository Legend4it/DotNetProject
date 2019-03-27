﻿using FeeCalculation;
using System;
using System.Globalization;
using TollFeeCalculator;

public class TollCalculator
{

    /**
     * Calculate the total toll fee for one day
     *
     * @param vehicle - the vehicle
     * @param dates   - date and time of all passes on one day
     * @return - the total toll fee for that day
     */

    public int GetTollFee(Vehicle vehicle, DateTime[] dates)
    {
        DateTime intervalStart = dates[0];
        int totalFee = 0;
        foreach (DateTime date in dates)
        {
            int nextFee = GetTollFee(date, vehicle);
            int tempFee = GetTollFee(intervalStart, vehicle);

            TimeSpan diffInMillies = date.Subtract(intervalStart);
            double minutes = Math.Round(diffInMillies.TotalMinutes);
            totalFee += nextFee;
        }

        if (totalFee > 60) totalFee = 60;

        return totalFee;
    }

    private bool IsTollFreeVehicle(Vehicle vehicle)
    {
        if (vehicle == null) return false;
        
        return Enum.IsDefined(typeof(TollFreeVehicles), vehicle.GetVehicleType());

    }

    public int GetTollFee(DateTime date, Vehicle vehicle)
    {
        if (IsTollFreeDate(date) || IsTollFreeVehicle(vehicle)) return 0;

        return Fee.GetFee(date);
    }

    private bool IsTollFreeDate(DateTime date)
    {

        if (IsWeekEnd(date)) return true;

        if (IsFeeFreeDay(date)) return true;

        return false;
    }

    private bool IsWeekEnd(DateTime date)
    {
        return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
    }

    private bool IsFeeFreeDay(DateTime date)
    {
        int year = date.Year;
        int month = date.Month;
        int day = date.Day;

        if (year == 2013)
        {
            if (month == 1 && day == 1 ||
                month == 3 && (day == 28 || day == 29) ||
                month == 4 && (day == 1 || day == 30) ||
                month == 5 && (day == 1 || day == 8 || day == 9) ||
                month == 6 && (day == 5 || day == 6 || day == 21) ||
                month == 7 ||
                month == 11 && day == 1 ||
                month == 12 && (day == 24 || day == 25 || day == 26 || day == 31))
            {
                return true;
            }
        }
        return false;

    }

    private enum TollFreeVehicles
    {
        Motorbike = 0,
        Tractor = 1,
        Emergency = 2,
        Diplomat = 3,
        Foreign = 4,
        Military = 5
    }
}