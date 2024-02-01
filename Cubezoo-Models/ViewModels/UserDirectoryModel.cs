using System;
using System.Collections.Generic;
using System.Text;

namespace Cubezoo_Models.ViewModels
{
    public class UserDirectoryModel
    {
        public List<DTO.UserDirectory> UserDirectoriesList { get; set; }
        public bool ShowReport { get; set; } = false;
        public bool duplicateEmailAddress { get; set; }
        public DTO.UserDirectory UserDirectory { get; set; }
    }
}
