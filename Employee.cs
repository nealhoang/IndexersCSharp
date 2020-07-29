using System;

namespace ThreadLesson
{
    public enum Gender: short
    {
        Male = 0,
        Female = 1,
        Unknown = 2
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public Employee()
        {
            
        }
     
        public object this[int key]
        {
            get
            {
                switch (key)
                {
                    case 0:
                        return ID;

                    case 1:
                        return Name;

                    case 2:
                        return Job;

                    case 3:
                        return Salary;

                    case 4:
                        return Location;

                    case 5:
                        return Department;

                    case 6:
                        return Gender;

                    default:
                        return null;
                }
            }
            set
            {
                switch (key)
                {
                    case 0:
                        ID = Convert.ToInt32(value);
                        break;

                    case 1:
                        Name = value.ToString();
                        break;

                    case 2:
                        Job = value.ToString();
                        break;

                    case 3:
                        Salary = Convert.ToDouble(value);
                        break;

                    case 4:
                        Location = value.ToString();
                        break;

                    case 5:
                        Department = value.ToString();
                        break;

                    case 6:
                        Gender = (Gender) value == Gender.Male ? Gender.Male : ((Gender) value == Gender.Female ? Gender.Female : Gender.Unknown);
                        break;

                }
            }
        }

        public object this[string key]
        {
            get =>
                key switch
                    {
                    nameof(ID) => ID,
                    nameof(Name) => Name,
                    nameof(Job) => Job,
                    nameof(Salary) => Salary,
                    nameof(Location) => Location,
                    nameof(Department) => Department,
                    nameof(Gender) => Gender,
                    _ => null,
                    };
            set
            {
                switch (key)
                {
                    case nameof(ID):
                        ID = Convert.ToInt32(value);
                        break;

                    case nameof(Name):
                        Name = value.ToString();
                        break;

                    case nameof(Job):
                        Job = value.ToString();
                        break;

                    case nameof(Salary):
                        Salary = Convert.ToDouble(value);
                        break;

                    case nameof(Location):
                        Location = value.ToString();
                        break;

                    case nameof(Department):
                        Department = value.ToString();
                        break;

                    case nameof(Gender):
                        Gender = (Gender) value == Gender.Male ? Gender.Male : ((Gender)value == Gender.Female? Gender.Female: Gender.Unknown);
                        break;

                }

            }
        }

    }
}
