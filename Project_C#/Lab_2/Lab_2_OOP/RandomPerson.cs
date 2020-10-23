using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork_2_ClassLib;

namespace Lab_2_OOP
{
    /// <summary>
    /// Класс, формирующий рандомного человека
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Рандом
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерация случайного взрослого/ребёнка
        /// </summary>
        /// <returns>Сгенерированный взрослый/ребёнок</returns>
        public static PersonBase CreateRandomPerson()
        {
            if (_random.Next(0, 2) == 0)
            {
                return CreateRandomAdult();
            }
            else
            {
                return CreateRandomChild();
            }
        }

        /// <summary>
        /// Генерация случайного взрослого
        /// </summary>
        /// <param name="wedlock">Статус брака</param>
        /// <param name="partner">Партнёр</param>
        /// <returns></returns>
        public static Adult CreateRandomAdult(bool wedlock = false, 
            Adult partner = null)
        {
            var randomAdult = new Adult();

            GeneratePersonInfo(randomAdult);

            randomAdult.Age = _random.Next(Adult.minAge, Adult.maxAge);

            var indexCompanyName = _random.Next(0, _companyList.Length - 1);
            randomAdult.PlaceOfWork = _companyList[indexCompanyName];

            randomAdult.PassportNumber = CreateRandomPassportData(true);
            randomAdult.PassportSerial = CreateRandomPassportData(false);

            if (wedlock == false)
            {
                randomAdult.MaritalStatus = 
                    (MaritalStatus)_random.Next(0, 3);

                if (randomAdult.MaritalStatus == MaritalStatus.Married)
                {
                    randomAdult.Partner = CreateRandomAdult(true, randomAdult);
                }
            }
            else
            {
                randomAdult.MaritalStatus = MaritalStatus.Married;
                randomAdult.Partner = partner;
            }
            
            return randomAdult;
        }

        /// <summary>
        /// Генерация случайного ребёнка
        /// </summary>
        /// <returns>Ребёнок</returns>
        public static Child CreateRandomChild()
        {
            var randomChild = new Child();

            GeneratePersonInfo(randomChild);

            randomChild.Age = _random.Next(Child.minAge, Child.maxAge);

            if (randomChild.Age >= 0 && randomChild.Age < 3)
            {
                randomChild.NameKindergartenOrSchool = "Не учится";
            }
            else if (randomChild.Age < 7)
            {
                var indexKindergarten = _random.Next(0, 100);
                randomChild.NameKindergartenOrSchool = 
                    $"Kindergarten №{indexKindergarten}";
            }
            else
            {
                var indexSchool = _random.Next(0, 100);
                randomChild.NameKindergartenOrSchool = 
                    $"School №{indexSchool}";
            }

            for (int i = 0; i < 2; i++)
            {
                int mother = _random.Next(0, 2);

                if (mother != 0)
                {
                    randomChild.Mother = CreateRandomAdult();
                }

                int father = _random.Next(0, 2);

                if (father != 0)
                {
                    randomChild.Father = CreateRandomAdult();
                }

            }

            return randomChild;
        }

        /// <summary>
        /// Метод, заполняющий базовые поля персоны
        /// </summary>
        /// <param name="peson"></param>
        public static void GeneratePersonInfo(PersonBase person)
        {
            int typeGender = _random.Next(0, 2);

            person.Gender = (Gender)typeGender;

            person.Surname = GetRandomValueFromList(_lastNameAll);
            person.Name = GetRandomValueFromList(
                typeGender == 1
                    ? _firstNameMan
                    : _firstNameWoman);
        }

        //TODO: XML
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listOfStrings"></param>
        /// <returns></returns>
        private static string GetRandomValueFromList(string[] listOfStrings)
        {
            var randomIndex = _random.Next(
                    0, listOfStrings.Length);
            return listOfStrings[randomIndex];
        }

        /// <summary>
        /// Генерация серии/номера паспорта. true - серия, false - номер.
        /// </summary>
        /// <param name="typePassportData">Тип данных паспорта (серия/номер)</param>
        /// <returns>Серия/номер паспорта</returns>
        public static string CreateRandomPassportData(bool typePassportData)
        {
             return typePassportData
                ? AddLeadingZeros(_random.Next(0, 9999).ToString(), 4)
                : AddLeadingZeros(_random.Next(0, 999999).ToString(), 6);
        }

        /// <summary>
        /// Метод, добавляющий нули в начале серии/номера паспорта
        /// </summary>
        /// <param name="passportData">Серия/номер паспорта</param>
        /// <param name="lenghtData">Длина серии/номера паспорта</param>
        /// <returns>Возвращает серию/номер паспорта с нулями в начале</returns>
        public static string AddLeadingZeros(string passportData, int lenghtData)
        {
            string newPassportData = passportData;

            if (passportData.Length != lenghtData)
            {
                for (int i = 0; i < lenghtData - passportData.Length; i++)
                {
                    newPassportData = "0" + newPassportData;
                }
            }

            return newPassportData;
        }

        /// <summary>
        /// Список компаний
        /// </summary>
        private static string[] _companyList = new string[]
        {
            "Apple",
            "Skolkovo",
            "Microsoft",
            "Pyatorochka",
            "System Operator",
            "BigRussianCompany"
        };

        /// <summary>
        /// Список мужских имён
        /// </summary>
        private static string[] _firstNameMan = new string[]
        {
            "Алексей",
            "Антон",
            "Сергей",
            "Владимир",
            "Дмитрий",
            "Кирилл"
        };

        /// <summary>
        /// Список женских имён
        /// </summary>
        private static string[] _firstNameWoman = new string[]
        {
            "Анастасия",
            "Мария",
            "Анна",
            "Алеся",
            "Светлана",
            "Александра"
        };

        /// <summary>
        /// Список фамилий
        /// </summary>
        private static string[] _lastNameAll = new string[]
        {
            "Евтушенко",
            "Коваленко",
            "Петренко",
            "Бродт",
            "Паскарь",
            "Денисенко"
        };
    }
}
