namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository()
        {
            _courses = new List<Course>{
                new Course(){Id=1,Title="ASP.NET Core Kursu",Description="Güzel Bir Kurs",Image="1.jpg",Tags=new string[]{"ASP Core","Web Geliştir"},isActive=true,isHome=true},
            new Course(){Id=2,Title="PHP Kursu",Description="Güzel Bir Kurs",Image="2.jpg",Tags=new string[]{"PHP","Web Geliştir"},isActive=true,isHome=true},
            new Course(){Id=3,Title="Node JS Kursu",Description="Güzel Bir Kurs",Image="3.jpg",Tags=new string[]{"Node JS","Web Geliştir"},isActive=true,isHome=true},
            new Course(){Id=4,Title="Javascript Kursu",Description="Güzel Bir Kurs",Image="2.jpg",Tags=new string[]{"Javascript","Web Geliştir"},isActive=false,isHome=true}
            };
        }
        public static List<Course> courses
        {
            get { return _courses; }
        }

        public static Course? GetById(int id)
        {
            return _courses.FirstOrDefault(kur => kur.Id == id);
        }

    }
}