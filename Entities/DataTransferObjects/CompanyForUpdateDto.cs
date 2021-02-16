using System.Collections.Generic;

namespace Entities.DataTransferObjects
{
    public class CompanyForUpdateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }

}
