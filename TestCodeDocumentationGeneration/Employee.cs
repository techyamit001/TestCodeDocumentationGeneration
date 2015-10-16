using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeDocumentationGeneration
{
    /// <summary>
    /// This is employee class.
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Gets or sets the EmployeeId.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the department to which this employee belongs.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public Departments Department { get; set; }
    }
}
