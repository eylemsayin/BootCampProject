using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class ApplicationState : Entity<short>
{
    public string Name { get; set; }
    public virtual ICollection<ApplicationEntity> ApplicationInformations { get; set; }

    public ApplicationState()
    {
        ApplicationInformations = new HashSet<ApplicationEntity>();
    }

    public ApplicationState(short id, string name)
        : this()
    {
        Id = id;
        Name = name;
    }

    public ApplicationState(string name)
        : this()
    {
        Name = name;
    }
}
