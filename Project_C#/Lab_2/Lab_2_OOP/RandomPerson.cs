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

            var companyNames = new CompanyNames();
            var indexCompanyName = 
                _random.Next(0, companyNames.companyList.Length - 1);
            randomAdult.PlaceOfWork = 
                companyNames.companyList[indexCompanyName];

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

        public static Child CreateRandomChild()
        {
            var randomChild = new Child();

            GeneratePersonInfo(randomChild);

            randomChild.Age = _random.Next(Child.minAge, Child.maxAge);

            EducationalInstitution educational = new EducationalInstitution();

            if (randomChild.Age >= 3 && randomChild.Age < 7)
            {
                var indexEducPlace = _random.Next(
                    0, educational.kindergartenList.Length - 1);

                randomChild.NameKindergartenOrSchool = 
                    educational.kindergartenList[indexEducPlace];
            }
            if (randomChild.Age >= 0 && randomChild.Age < 3)
            {
                randomChild.NameKindergartenOrSchool = "Не учится";
            }
            else
            {
                var indexEducPlace = _random.Next(
                    0, educational.schoolList.Length - 1);

                randomChild.NameKindergartenOrSchool =
                    educational.schoolList[indexEducPlace];
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

            if (typeGender == 0)
            {
                person.Gender = Gender.Male;

                ListNameSurname nameSurname = new ListNameSurname();

                var randomIndexName = _random.Next(
                    0, nameSurname.firstNameMan.Length - 1);

                person.Name = nameSurname.firstNameMan[randomIndexName];

                var randomIndexSurname = _random.Next(
                    0, nameSurname.lastNameAll.Length - 1);

                person.Surname = nameSurname.lastNameAll[randomIndexSurname];
            }
            else
            {
                person.Gender = Gender.Female;

                ListNameSurname nameSurname = new ListNameSurname();

                var randomIndexName = _random.Next(
                    0, nameSurname.firstNameWoman.Length - 1);

                person.Name = nameSurname.firstNameWoman[randomIndexName];

                var randomIndexSurname = _random.Next(
                    0, nameSurname.lastNameAll.Length - 1);

                person.Surname = nameSurname.lastNameAll[randomIndexSurname];
            }
        }

        /// <summary>
        /// Генерация серии/номера паспорта. true - серия, false - номер.
        /// </summary>
        /// <param name="typePassportData">Тип данных паспорта (серия/номер)</param>
        /// <returns>Серия/номер паспорта</returns>
        public static string CreateRandomPassportData(bool typePassportData)
        {
            string number;

            if (typePassportData == true)
            {
                number = AddLeadingZeros(_random.Next(0, 9999).ToString(), 4);
            }
            else
            {
                number = AddLeadingZeros(_random.Next(0, 999999).ToString(), 6);
            }

            return number;
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
    }
}
