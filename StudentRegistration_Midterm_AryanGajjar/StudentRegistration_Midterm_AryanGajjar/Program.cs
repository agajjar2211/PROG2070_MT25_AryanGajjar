using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// name: Aryan Gajjar      email: agajjar2211@conestogac.on.ca      student no.: 8972211
namespace StudentRegistration_Midterm_AryanGajjar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Registration
    {
        private const int MaxNameLength = 40;
        private const int MaxAge = 125;
        private const int MaxGroupSize = 18;

        // <summary>
        // Registers a student with their name.
        // </summary>
        // <param name="name">The student's name.</param>
        // <returns>The registered student's name.</returns>
        public string RegisterName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty.");
            }

            if (name.Length > MaxNameLength)
            {
                throw new ArgumentException($"Name cannot exceed {MaxNameLength} characters.");
            }

            return name;
        }

        // <summary>
        // Registers a student's age.
        // </summary>
        // <param name="age">The student's age.</param>
        // <returns>The registered student's age.</returns>
        public int RegisterAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative.");
            }

            if (age > MaxAge)
            {
                throw new ArgumentOutOfRangeException($"Age cannot exceed {MaxAge}.");
            }

            return age;
        }

        // <summary>
        // Registers the group size for a student's project or activity.
        // </summary>
        // <param name="groupSize">The size of the group.</param>
        // <returns>The registered group size.</returns>
        public int RegisterGroupSize(int groupSize)
        {
            if (groupSize <= 0)
            {
                throw new ArgumentOutOfRangeException("Group size must be greater than zero.");
            }

            if (groupSize > MaxGroupSize)
            {
                throw new ArgumentOutOfRangeException($"Group size cannot exceed {MaxGroupSize}.");
            }

            return groupSize;
        }
    }
}
