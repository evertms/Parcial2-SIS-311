using System.Xml.Linq;
using Appointment.Domain.Entities;

namespace Appointment.Domain.Interfaces;

public interface ICrudOperations
{
    void Save(Model model);
}