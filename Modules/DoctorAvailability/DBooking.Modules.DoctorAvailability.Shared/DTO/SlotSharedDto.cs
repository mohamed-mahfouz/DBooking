﻿namespace DBooking.Modules.DoctorAvailability.Shared.DTO
{
    public class SlotSharedDto
    {
        public string DoctorName { get; set; } = null!;
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
        public DateTime Time { get; set; }
    }
}
