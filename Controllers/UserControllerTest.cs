using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OAM_Backend.Models;
using OAM_Backend.Models.Responses;
using OAM_Backend.Services;
using Xunit;

namespace OAM_Backend.Test.Controllers
{
    public class UserControllerTest
    {
        private Mock<IUserService> _mockUserService;
        private readonly Mock<IAssignmentService> _mockAssignmentService;

        static List<User> _user = new List<User>
        {
            new User
                   {
                       Id = 1,
                       Staffcode = "SD0001",
                       Username = "ducvm",
                       Password = BCrypt.Net.BCrypt.HashPassword("Rookiesms1"),
                       FirstName = "Duc",
                       LastName = "Vu Minh",
                       DOB = new DateTime(2000, 08, 09),
                       JoinedDate = new DateTime(2022, 01, 01),
                       Gender = true,
                       Location = "Ha Noi",
                       LogCount = 1,
                       IsActive = true,
                       IsAdmin = true
                   },
                   new User
                   {
                       Id = 2,
                       Staffcode = "SD0002",
                       Username = "daohq",
                       Password = BCrypt.Net.BCrypt.HashPassword("Rookiesms1"),
                       FirstName = "Dao",
                       LastName = "Hoang Quy",
                       DOB = new DateTime(1996, 02, 22),
                       JoinedDate = new DateTime(2022, 01, 01),
                       Gender = true,
                       Location = "Ha Noi",
                       LogCount = 1,
                       IsActive = true,
                       IsAdmin = true
                   },
                   new User
                   {
                       Id = 3,
                       Staffcode = "SD0003",
                       Username = "huyennt",
                       Password = BCrypt.Net.BCrypt.HashPassword("Rookiesms1"),
                       FirstName = "Huyen",
                       LastName = "Nguyen Thu",
                       DOB = new DateTime(2001, 08, 16),
                       JoinedDate = new DateTime(2022, 01, 01),
                       Gender = true,
                       Location = "Ha Noi",
                       LogCount = 1,
                       IsActive = true,
                       IsAdmin = true
                   },
                   new User
                   {
                       Id = 4,
                       Staffcode = "SD0004",
                       Username = "hungtp",
                       Password = BCrypt.Net.BCrypt.HashPassword("Rookiesms1"),
                       FirstName = "Hung",
                       LastName = "Ta Phi",
                       DOB = new DateTime(2000, 10, 25),
                       JoinedDate = new DateTime(2022, 01, 01),
                       Gender = true,
                       Location = "Ha Noi",
                       LogCount = 1,
                       IsActive = true,
                       IsAdmin = false
                   },
                   new User
                   {
                       Id = 5,
                       Staffcode = "SD0005",
                       Username = "phuongnn",
                       Password = BCrypt.Net.BCrypt.HashPassword("Rookiesms1"),
                       FirstName = "Phuong",
                       LastName = "Nguyen Nam",
                       DOB = new DateTime(2001, 01, 22),
                       JoinedDate = new DateTime(2022, 01, 01),
                       Gender = true,
                       Location = "Ha Noi",
                       LogCount = 1,
                       IsActive = true,
                       IsAdmin = false
                   },
                   new User
                   {
                       Id = 6,
                       Staffcode = "SD0006",
                       Username = "maibt",
                       Password = BCrypt.Net.BCrypt.HashPassword("Rookiesms1"),
                       FirstName = "Mai",
                       LastName = "Bui Tuyet",
                       DOB = new DateTime(2000, 11, 10),
                       JoinedDate = new DateTime(2022, 01, 01),
                       Gender = true,
                       Location = "Ha Noi",
                       LogCount = 1,
                       IsActive = true,
                       IsAdmin = false
                   }
        };


        public UserControllerTest()
        {
            _mockUserService = new Mock<IUserService>();
            _mockAssignmentService = new Mock<IAssignmentService>();
        }

    }
}
