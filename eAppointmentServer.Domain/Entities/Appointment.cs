﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Domain.Entities
{
  public sealed  class Appointment
    {
        public Appointment()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor? doctor { get; set; }
        public Guid PatientId { get; set; }
        public Patient? patient { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public  bool  IsCompleted { get; set; }


    }
}
