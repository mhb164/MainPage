using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public readonly record struct PersianDate
    {
        public int Year { get; init; }
        public int Month { get; init; }
        public int Day { get; init; }
        public DayOfWeek DayOfWeek { get; init; }


        public readonly int DateAsNumber => Year * 10000 + Month * 100 + Day;
        public readonly int YearMonthAsNumber => Year * 100 + Month;
        public readonly string Simple => $"{Year}/{Month:d2}/{Day:d2}".ToPersian();
        public readonly string SimpleDashed => $"{Year}-{Month:d2}-{Day:d2}".ToPersian();

        public readonly string SimpleEnglish => $"{Year:d4}/{Month:d2}/{Day:d2}";
        public readonly string SimpleEnglishDashed => $"{Year:d4}-{Month:d2}-{Day:d2}";

        public readonly string Persian => $"{DayText} {MonthText} {Year}".ToPersian();
        public readonly string Weekday => $"{DayOfWeekText} {Day} {MonthText} {Year}".ToPersian();

        public readonly string DayOfWeekText => DayOfWeek switch
        {
            DayOfWeek.Saturday => "شنبه",
            DayOfWeek.Sunday => "یکشنبه",
            DayOfWeek.Monday => "دوشنبه",
            DayOfWeek.Tuesday => "سه‌شنبه",
            DayOfWeek.Wednesday => "چهارشنبه",
            DayOfWeek.Thursday => "پنجشنبه",
            DayOfWeek.Friday => "جمعه",
            _ => throw new InvalidOperationException($"{DayOfWeek} not valid DayOfWeek!"),
        };

        public readonly string MonthText => Month switch
        {
            1 => "فروردین",
            2 => "اردیبهشت",
            3 => "خرداد",
            4 => "تیر",
            5 => "مرداد",
            6 => "شهریور",
            7 => "مهر",
            8 => "آبان",
            9 => "آذر",
            10 => "دی",
            11 => "بهمن",
            12 => "اسفند",
            _ => throw new InvalidOperationException($"{Month} not valid Month!"),
        };

        public readonly string DayText => Day switch
        {
            1 => "اول",
            2 => "دوم",
            3 => "سوم",
            4 => "چهارم",
            5 => "پنجم",
            6 => "ششم",
            7 => "هفتم",
            8 => "هشتم",
            9 => "نهم",
            10 => "دهم",
            11 => "يازدهم",
            12 => "دوازدهم",
            13 => "سيزدهم",
            14 => "چهاردهم",
            15 => "پانزدهم",
            16 => "شانزدهم",
            17 => "هفدهم",
            18 => "هجدهم",
            19 => "نوزدهم",
            20 => "بيست",
            21 => "بيست و يکم",
            22 => "بيست و دوم",
            23 => "بيست و سوم",
            24 => "بيست و چهارم",
            25 => "بيست و پنجم",
            26 => "بيست و ششم",
            27 => "بيست و هفتم",
            28 => "بيست و هشتم",
            29 => "بيست و نهم",
            30 => "سي",
            31 => "سي و يکم",
            _ => throw new InvalidOperationException($"{Day} not valid Day!"),
        };
    }
}
