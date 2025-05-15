using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace University
{
    public class clsPublicVariable
    {

        public static View_User User { get; set; }

        public static List<tblRole> UserRoles { get; set; }
        public static List<tblRoleAccess> UserRoleAccess { get; set; }
        public static List<tblExtraAccess> UserExtraAccess { get; set; }

        public static int AdminId = 15;
        public static int TeacherId = 13;
        public static int StudentId = 14;
        public enum UsersType
        {
            BasicEmployee = 0,
            Student,
            Teacher,
            Employee,
            Admin
        }

        public static Random rnd = new Random();
        public static DateTime dt = new DateTime();
        public static PersianCalendar prs = new PersianCalendar();
        public static Term openTerm = Term.mehr;
        public static int Year = 1403;
        public enum Score_Type
        {
            ClassPoint,
            MidTerm,
            Final,
            Average
        }

        public enum Term
        {
            mehr = 1,
            bahman,
            tabestan = 3
        }

        public static tblUser SelectedTeacher { get; set; }
        public static View_ClassRoom SelectedClasstoAdd { get; set; }

        public enum Week
        {
            Saturday = 1,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday = 7
        }
        public enum Request_type
        {
            ProfilePictureChange = 1,
            StudentClassroomMappingLicense,
            GradeReview
        }
        public enum RequestStatus
        {
            Pending = 1,
            Approved,
            Rejected
        }

        public static void Folder()
        {
            if (!Directory.Exists(Photo_Address))
                Directory.CreateDirectory(Photo_Address);
            if (!Directory.Exists(Profile_Photos_Address))
                Directory.CreateDirectory(Profile_Photos_Address);
            if (!Directory.Exists(Video_Address))
                Directory.CreateDirectory(Video_Address);
            if (!Directory.Exists(File_Address))
                Directory.CreateDirectory(File_Address);

        }
        public static string Photo_Address = Application.StartupPath + "\\Photos";
        public static string Profile_Photos_Address = Photo_Address + "\\Profile Photos";
        public static string Video_Address = Application.StartupPath + "\\Videos";
        public static string File_Address = Application.StartupPath + "\\Files";
        public static void req_approved(View_Requests request)
        {
            University_DBEntities db = new University_DBEntities();
            if (request.RequestType == (int)Request_type.ProfilePictureChange)
            {
                tblUser user = db.tblUsers.Where(u => u.Id == request.RequesterId).FirstOrDefault();
                user.PhotoId = request.FileId;
                db.tblUsers.AddOrUpdate(user);
                db.SaveChanges();
            }
            Fill_public(User.UserId);
        }

        public static void Fill_public(int userid)
        {
            University_DBEntities db = new University_DBEntities();
            UserRoles = new List<tblRole>();
            UserRoleAccess = new List<tblRoleAccess>();
            UserExtraAccess = new List<tblExtraAccess>();
            User = db.View_User.Where(u => u.UserId == userid).First();
            List<tblRoleToUser> ur = db.tblRoleToUsers.Where(r => r.UserId == userid).ToList();
            foreach (tblRoleToUser role in ur)
                UserRoles = db.tblRoles.Where(r => r.Id == role.RoleId).ToList();
            foreach (tblRole role in UserRoles)
                UserRoleAccess.AddRange(db.tblRoleAccesses.Where(r => r.RoleId == role.Id).ToList());
            UserExtraAccess = db.tblExtraAccesses.Where(a => a.UserId == userid).ToList();
        }
        public static View_User Selected_Receiver = new View_User();    
    }
}
