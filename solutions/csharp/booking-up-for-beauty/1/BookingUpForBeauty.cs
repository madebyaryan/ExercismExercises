using System;
using System.Globalization;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        string[] format = [
            "M/d/yyyy H:mm:ss",
            "MMMM d, yyyy H:mm:ss",
            "dddd, MMMM d, yyyy HH:mm:ss"
        ];
        DateTime parsedDate = DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.CurrentCulture, DateTimeStyles.None);
        return parsedDate;
    }

    public static bool HasPassed(DateTime appointmentDate)=> appointmentDate < DateTime.Now;
    
    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        TimeSpan start = TimeSpan.Parse("12:00");
        TimeSpan end = TimeSpan.Parse("18:00");
        if (appointmentDate.TimeOfDay >= start && appointmentDate.TimeOfDay < end)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        string format = "M/d/yyyy h:mm:ss tt";
        string formattedString = appointmentDate.ToString(format, CultureInfo.CurrentCulture);
        return $"You have an appointment on {formattedString}.";
    }

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);
}
