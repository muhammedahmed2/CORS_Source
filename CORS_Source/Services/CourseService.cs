using System;
using System.Linq;
using System.Collections.Generic;
using CORS_Source.Models;

namespace CORS_Source.Services
{
    public class CourseService
    {
        public List<Course> course_lst;

        public CourseService()
        {

            course_lst = new List<Course>();
            {
                new Course() { CourseID = 1, CourseName = "Az-204" };
                new Course() { CourseID = 2, CourseName = "Az-404" };
                new Course() { CourseID = 1, CourseName = "Az-304" };
            };


        }

        public IEnumerable<Course> GetCourses()
        {
            return (course_lst);
        }
    }
 }
