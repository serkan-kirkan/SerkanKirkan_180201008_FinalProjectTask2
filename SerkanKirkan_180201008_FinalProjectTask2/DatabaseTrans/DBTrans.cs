using SerkanKirkan_180201008_FinalProjectTask2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SerkanKirkan_180201008_FinalProjectTask2.DatabaseTrans
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<BookClass>();
            conn.CreateTable<CategoryClass>();
            conn.CreateTable<StudentClass>();
            conn.CreateTable<DepartmentClass>();
            conn.CreateTable<EnrollmentClass>();

        }

        public List<CategoryClass> Update()
        {
            Init();
            return conn.Table<CategoryClass>().Select(x => x.Category_Name).ToList();
        }

        public List<BookClass> GetAllBooks()
        {
            Init();
            return conn.Table<BookClass>().ToList();
        }
        public void AddBook(BookClass book)
        {
            conn=new SQLiteConnection(this.dbPath);
            conn.Insert(book);
        }
        
        public void DeleteBook(int Sel_Book_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new BookClass {Book_ID=Sel_Book_ID });
        }

        public List<CategoryClass> GetAllCategories()
        {
            Init();
            return conn.Table<CategoryClass>().ToList();
        }

        public void AddCategory(CategoryClass category)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(category);
        }

        public void DeleteCategory(int Sel_Category_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new CategoryClass { Category_ID = Sel_Category_ID });
        }

        public List<StudentClass> GetAllStudent()
        {
            Init();
            return conn.Table<StudentClass>().ToList();
        }
        public void AddStudent(StudentClass student)
        {
            conn= new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void DeleteStudent(int Sel_Student_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentClass { Student_ID = Sel_Student_ID });
        }

        public List<DepartmentClass> GetAllDepartments()
        {
            Init();
            return conn.Table<DepartmentClass>().ToList();
        }
        public void AddDepartment(DepartmentClass department)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(department);
        }

        public void DeleteDepartment(int Sel_Department_ID) 
        { 
            conn= new SQLiteConnection(this.dbPath);
            conn.Delete(new DepartmentClass { Department_ID = Sel_Department_ID});
        }
        public List<EnrollmentClass> GetAllEnrollments()
        {
            Init();
            return conn.Table<EnrollmentClass>().ToList();
        }
        public void AddEnrollment(EnrollmentClass enrollment)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(enrollment);
        }

        public void DeleteEnrollment(int Sel_Enroll_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new EnrollmentClass { Enroll_ID = Sel_Enroll_ID });
        }

    }
}
