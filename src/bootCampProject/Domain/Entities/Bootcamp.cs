﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Bootcamp : Entity<int>
{
    public string Name { get; set; }
    public Guid InstructorId { get; set; }
    public short BootcampStateId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual Instructor? Instructor { get; set; }
    public virtual BootcampState? BootcampState { get; set; }
    public virtual ICollection<ApplicationEntity> Applications { get; set; }
    public virtual ICollection<BootcampImage> BootcampImages { get; set; }

    public Bootcamp()
    {
        Applications = new HashSet<ApplicationEntity>();
        BootcampImages = new HashSet<BootcampImage>();
    }

    public Bootcamp(int id, Guid instructorId, short bootcampStateId, string name, DateTime startDate, DateTime endDate)
        : this()
    {
        Id = id;
        InstructorId = instructorId;
        BootcampStateId = bootcampStateId;
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
    }
}
