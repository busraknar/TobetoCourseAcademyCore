
using Entities.Concretes;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using System.Runtime.InteropServices;
using Entities.DTOs;
using Core.Utilies.Results;

//Category category1 = new Category();
//category1.Id = 1;
//category1.Name = "Programlama";

Course course1 = new Course();
//course1.Id = 1;
course1.Name = "J";
course1.CategoryId = 2;
course1.InstructorId = 1;
course1.Title = "Javascript";


//CategoryManager categoryManager=new CategoryManager();
//categoryManager.Add(course1);

Course course2 = new Course();

course2.Name = "Java Dersleri";
course2.InstructorId = 1;
course2.CategoryId = 1;
course2.Title = "Java kodluyoruz";

//categoryManager.Add(course2);

//DataManager dataManager = new DataManager();
//dataManager.Add(course1);

//courseManager.Add(course1);
//courseManager.Add(course2);
CourseManager courseManager = new CourseManager(new EfCourseDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
//List<Course> courses= courseManager.GetAll();

//Console.WriteLine("------Kurslar-----");


//foreach (var item in courses)
//{
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.Title);
//}
//Console.WriteLine("------Eğitmenler------");
//List<Instructor> instructors = instructorManager.GetAll();
//foreach (var item in instructors)
//{
//    Console.WriteLine(item.Name);

//}
//Console.WriteLine("-------Kategoriler----");
//List<Category> categories = categoryManager.GetAll();
//foreach (var item in categories)
//{
//    Console.WriteLine(item.Name);
//}

//IDataResult<List<CourseDetailDto>> details = courseManager.GetDetails();
//Console.WriteLine(details.Success);
//Console.WriteLine(details.Message);
//Console.WriteLine("***************");
//foreach (var item in details.Data)
//{
//    Console.WriteLine("Kursun adı="+item.Name+"\nKategori="+ item.CategoryName+ "\nEğitmen ="+item.InstructorName);
//    Console.WriteLine("-------------");

//}

IDataResult<List<Course>> details = courseManager.GetAll();
Console.WriteLine(details.Success);
Console.WriteLine(details.Message);
Console.WriteLine("***************");
if (details.Success)
{
    foreach (var item in details.Data)
    {
        Console.WriteLine("Kursun adı=" + item.Name);
        Console.WriteLine("-------------");

    }
}


//IResult result = courseManager.Add(course1);
//Console.WriteLine(result.Success);
//Console.WriteLine(result.Message);

//IResult result2 = courseManager.Add(course2);
//Console.WriteLine(result2.Success);
//Console.WriteLine(result2.Message);