using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Добавить ссылку на партнёра

namespace LabWork_2_ClassLib
{
    /// <summary>
    /// Взрослый человек
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Минимальный возраст взрослого человека
        /// </summary>
        public const int minAge = 18;

        /// <summary>
        /// Максимальный возраст взрослого человека
        /// </summary>
        public const int maxAge = 100;

        /// <summary>
        /// Возраст
        /// </summary>
        public override int Age
        {
            get { return _age; }
            set 
            { 
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(Age)} должен быть в пределах " +
                        $"от {minAge} до {maxAge}");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Семейное положение
        /// </summary>
        private MaritalStatus _maritalStatus;

        /// <summary>
        /// Семейное положение
        /// </summary>
        public MaritalStatus MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        private string _passportNumber;

        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string PassportNumber
        {
            get { return _passportNumber; }
            set
            {
                CheckingCorrectnessPassportData(value, 4);
                _passportNumber = value;
            }
        }

        /// <summary>
        /// Серия паспорта
        /// </summary>
        private string _passportSerial;

        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string PassportSerial
        {
            get { return _passportSerial; }
            set
            {
                CheckingCorrectnessPassportData(value, 6);
                _passportSerial = value;
            }
        }
       
        /// <summary>
        /// Место работы
        /// </summary>
        private string _placeOfWork;

        /// <summary>
        /// Место работы
        /// </summary>
        public string PlaceOfWork
        {
            get { return _placeOfWork; }
            set { _placeOfWork = value; }
        }

        /// <summary>
        /// Партнёр
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Партнёр
        /// </summary>
        public Adult Partner
        {
            get { return _partner; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        $"{nameof(Partner)}", $"{nameof(Partner)} отсуствует");
                }

                if (MaritalStatus == MaritalStatus.Married &&
                    value.MaritalStatus == MaritalStatus.Married)
                {
                    _partner = value;
                }
            }
        }

        /// <summary>
        /// Проверка правильности ввода серии/номера паспорта
        /// </summary>
        /// <param name="value">Сообщаемое значение серии/номера паспорта</param>
        /// <param name="lenght">Количество символов в серии/номере паспорта</param>
        public void CheckingCorrectnessPassportData(string value, int lenght)
        {
            if (value.Length != lenght)
            {
                throw new ArgumentException($"Длина должна быть равна {lenght}. " +
                     "\nФормат заполнения для серии (0000, 1234, 0001 и т.д.). " +
                     "\nФормат заполнения для номера (000000, 123456, 000001 и т.д.).");
            }
        }

        /// <summary>
        /// Метод, формирующий информацию о взрослом
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public override string InfoAboutPerson()
        {
            var infoAboutPerson = base.InfoAboutPerson() +
                $"Серия паспорта: {PassportSerial} | " +
                $"Номер паспорта: {PassportNumber} | " +
                $"Семейное положение: {MaritalStatus} | ";

            if (MaritalStatus == MaritalStatus.Married)
            {
                infoAboutPerson += $"Партнёр: {Partner.Surname} {Partner.Name} | ";
            }

            infoAboutPerson += $"Место работы: ";

            if (string.IsNullOrEmpty(PlaceOfWork))
            {
                infoAboutPerson += "Безработный | ";
            }    
            else
            {
                infoAboutPerson += PlaceOfWork + " | ";
            }

            return infoAboutPerson;
        }

        /// <summary>
        /// Метод, характерный для класса Adult
        /// </summary>
        /// <returns>Строка</returns>
        public string AdultWork()
        {
            return "Взрослый работает летом!";
        }
    }
}
