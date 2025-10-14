using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            // Додавання лікарів
            hospital.AddDoctor(new Doctor(1, "Кислянка Ярослав", "Невролог"));
            hospital.AddDoctor(new Doctor(2, "Кармаза Максим", "Кардіолог"));
            hospital.AddDoctor(new Doctor(3, "Карпенко Роман", "Педіатр"));

            // Реєстрація пацієнтів
            hospital.RegisterPatient(new Patient(1, "Лихно Михайло", 18));
            hospital.RegisterPatient(new Patient(2, "Кравченко Юрій", 23));
            hospital.RegisterPatient(new Patient(3, "Безсмерний Руслан", 19));

            // Створення палат
            hospital.CreateRoom(new HospitalRoom(101, 2));
            hospital.CreateRoom(new HospitalRoom(102, 1));

            // Госпіталізація
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);

            // Медичні записи
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[0], hospital.Doctors[0], DateTime.Now, "ГРВІ"));
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[1], hospital.Doctors[1], DateTime.Now, "Апендектомія"));

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
