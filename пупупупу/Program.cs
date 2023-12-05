using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace пупупупу
{
    //интерфейс

    public interface IPrintable
    {
        void ShowProperties();
    }
    //Класс животные (абстрактный)
    abstract class Animal
    {
        public string Name { get; set; }
        public string Movement { get; set; }

        public Animal(string name, string movement)
        {
            if (!IsNameValid(name))
            {
                throw new ArgumentException("Название должно содержать только буквы.", nameof(name));
            }
            Name = name;
            if (!IsMovementValid(movement))
            {
                throw new ArgumentException("Передвежение должно содержать только буквы.", nameof(movement));
            }
            Movement = movement;
        }
        private bool IsNameValid(string name)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(name, pattern);
        }
        private bool IsMovementValid(string movement)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(movement, pattern);
        }
        public virtual void ShowProperties()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Способ передвежения: {Movement}");

        }

        public override string ToString()
        {
            return $"{GetType().Name}: Название = {Name}, Передвежение = {Movement}";
        }
    }
    //Класс млекопитающие
    class Mammal : Animal
    {
        public string Typeofwool { get; set; }
        public Mammal(string name, string movement, string typeofwool) : base(name, movement)
        {
            if (!IsTypeofwoolValid(typeofwool))
            {
                throw new ArgumentException("Тип шерсти должен содержать только буквы.", nameof(typeofwool));
            }
            Typeofwool = typeofwool;
        }
        private bool IsTypeofwoolValid(string typeofwool)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(typeofwool, pattern);
        }

        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine($"Тип шерсти: {Typeofwool}");
        }

        public override string ToString()
        {
            return $"Тип шерсти: {Typeofwool}";
        }
        //Переопределяем все методы унаследованные от Object
        public override bool Equals(object obj)
        {
            if (obj is Mammal other)
            {
                return this.Typeofwool == other.Typeofwool;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Typeofwool.GetHashCode();
        }

        public new Type GetType()
        {
            return base.GetType();
        }


    }
    //Класс птицы
    class Bird : Animal
    {
        public string BeakType { get; set; }
        public Bird(string name, string movement, string beakType) : base(name, movement)
        {
            if (!IsBeakTypeValid(beakType))
            {
                throw new ArgumentException("Тип клюва должен содержать только буквы.", nameof(beakType));
            }
            BeakType = beakType;
        }
        private bool IsBeakTypeValid(string beakType)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(beakType, pattern);
        }
        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine($"Тип клюва: {BeakType}");

        }
        public override string ToString()
        {
            return $"Тип клюва: {BeakType}";
        }
    }
    //Класс рыбы
    class Fish : Animal
    {
        public string FinType { get; set; }
        public Fish(string name, string movement, string finType) : base(name, movement)
        {
            if (!IsFinTypeValid(finType))
            {
                throw new ArgumentException("Тип жабер должен содержать только буквы.", nameof(finType));
            }
            FinType = finType;
        }
        private bool IsFinTypeValid(string finType)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(finType, pattern);
        }
        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine($"Тип жабер: {FinType}");


        }
        public override string ToString()
        {
            return $"Тип жабер: {FinType}";
        }
    }
    //Класс рептилии
    class Reptiles : Animal
    {
        public string Typeofbloodcirculation { get; set; }
        public Reptiles(string name, string movement, string typeofbloodcirculation) : base(name, movement)
        {
            if (!IsTypeofbloodcirculationValid(typeofbloodcirculation))
            {
                throw new ArgumentException("Тип кровообращения должен содержать только буквы.", nameof(typeofbloodcirculation));
            }
            Typeofbloodcirculation = typeofbloodcirculation;
        }
        private bool IsTypeofbloodcirculationValid(string typeofbloodcirculation)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(typeofbloodcirculation, pattern);
        }
        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine($"Тип кровообращения: {Typeofbloodcirculation}");


        }
        public override string ToString()
        {
            return $"Тип кровообращения: {Typeofbloodcirculation}";
        }
    }


    //Класс лев
    class Lion : Mammal
    {
        public string RoarType { get; set; }
        public string PositionInThePride { get; set; }

        public Lion(string name, string movement, string typeofwool, string roarType, string positionInThePride) : base(name, movement, typeofwool)
        {
            if (!IsRoarTypeValid(roarType))
            {
                throw new ArgumentException("Тип рева должен содержать только буквы.", nameof(roarType));
            }
            RoarType = roarType;
            if (!IsPositionInThePrideValid(positionInThePride))
            {
                throw new ArgumentException("Положение в прайде должно содержать только буквы.", nameof(positionInThePride));
            }
            PositionInThePride = positionInThePride;
        }

        private bool IsRoarTypeValid(string roarType)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(roarType, pattern);
        }
        private bool IsPositionInThePrideValid(string positionInThePride)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(positionInThePride, pattern);
        }
        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine($"Тип рева: {RoarType}");
        }

        public override string ToString()
        {
            return $"Положение в прайде: {PositionInThePride}";
        }

    }
    //Класс тигр
    class Tiger : Mammal
    {
        public string ColorType { get; set; }
        public string TigerType { get; set; }

        public Tiger(string name, string movement, string skinType, string colorType, string tigerType) : base(name, movement, skinType)
        {
            if (!IsColorTypeValid(colorType))
            {
                throw new ArgumentException("Тип окраса должен содержать только буквы.", nameof(colorType));
            }
            ColorType = colorType;
            if (!IsTigerTypeValid(tigerType))
            {
                throw new ArgumentException("Тип тигра должен содержать только буквы.", nameof(tigerType));
            }
            TigerType = tigerType;
        }
        private bool IsColorTypeValid(string colorType)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(colorType, pattern);
        }
        private bool IsTigerTypeValid(string tigerType)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(tigerType, pattern);
        }

        public override void ShowProperties()
        {
            base.ShowProperties();

            Console.WriteLine($"Тип окраса: {ColorType}");

        }
        public override string ToString()
        {
            return $"Тип тигра: {TigerType}";
        }
    }
    //Класс сова
    class Owl : Bird
    {
        public string NightVision { get; set; }
        public int ViewingAngle { get; set; }

        public Owl(string name, string movement, string beakType, string nightVision, int viewingAngle) : base(name, movement, beakType)
        {
            if (!IsNightVisionValid(nightVision))
            {
                throw new ArgumentException("Ночное зрение должно содержать только буквы.", nameof(nightVision));
            }
            NightVision = nightVision;
            if (!IsViewingAngleValid(viewingAngle))
            {
                throw new ArgumentException("Угол обзора должен содержать только буквы.", nameof(viewingAngle));
            }
            ViewingAngle = viewingAngle;
        }
        private bool IsNightVisionValid(string nightVision)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(nightVision, pattern);
        }
        private bool IsViewingAngleValid(int viewingAngle)
        {
            return viewingAngle >= 0;
        }
        public override void ShowProperties()
        {
            base.ShowProperties();

            Console.WriteLine($"Ночное зрение: {NightVision}");

        }
        public override string ToString()
        {
            return $"Угол обзора: {ViewingAngle}";
        }
    }
    //Класс попугай
    class Parrot : Bird
    {
        public string FeatherColor { get; set; }
        public int WordCount { get; set; }
        public Parrot(string name, string movement, string beakType, string featherColor, int wordCount) : base(name, movement, beakType)
        {
            if (!IsFeatherColorValid(featherColor))
            {
                throw new ArgumentException("Цвет пера должен содержать только буквы.", nameof(featherColor));
            }
            FeatherColor = featherColor;
            if (!IsWordCountValid(wordCount))
            {
                throw new ArgumentException("Количество слов должен содержать только буквы.", nameof(wordCount));
            }
            WordCount = wordCount;
        }
        private bool IsFeatherColorValid(string featherColor)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(featherColor, pattern);
        }
        private bool IsWordCountValid(int wordCount)
        {
            return wordCount >= 0;
        }
        public override void ShowProperties()
        {

            base.ShowProperties();

            Console.WriteLine($"Цвет пера: {FeatherColor}");

        }
        public override string ToString()
        {
            return $"Количество слов, которое знает птица: {WordCount}";
        }

    }
    //Акула
    class Shark : Fish
    {
        public string HuntingStyle { get; set; }
        public string TeethType { get; set; }
        public Shark(string name, string movement, string finType, string huntingStyle, string teethType) : base(name, movement, finType)
        {
            if (!IsHuntingStyleValid(huntingStyle))
            {
                throw new ArgumentException("Стиль охоты должен содержать только буквы.", nameof(huntingStyle));
            }
            HuntingStyle = huntingStyle;
            if (!IsTeethTypeValid(teethType))
            {
                throw new ArgumentException("Тип зубов должен содержать только буквы.", nameof(teethType));
            }
            TeethType = teethType;
        }
        private bool IsHuntingStyleValid(string huntingStyle)
        {
            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(huntingStyle, pattern);
        }
        private bool IsTeethTypeValid(string teethType)
        {
            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(teethType, pattern);
        }
        public override void ShowProperties()
        {
            base.ShowProperties();

            Console.WriteLine($"Стиль охоты: {HuntingStyle}");

        }
        public override string ToString()
        {
            return $"Тип зубов: {TeethType}";
        }
    }
    //Класс крокодил (бесплодный)
    sealed class Crocodile : Reptiles
    {
        public string JawStrength { get; set; }
        public string ColorOfTheSkin { get; set; }
        public Crocodile(string name, string movement, string typeofbloodcirculation, string jawStrength, string colorOfTheSkin) : base(name, movement, typeofbloodcirculation)
        {
            if (!IsJawStrengthValid(jawStrength))
            {
                throw new ArgumentException("Сила челюсти должна содержать только буквы.", nameof(jawStrength));
            }
            JawStrength = jawStrength;
            if (!IsColorOfTheSkinValid(colorOfTheSkin))
            {
                throw new ArgumentException("Сила челюсти должна содержать только буквы.", nameof(colorOfTheSkin));
            }
            ColorOfTheSkin = colorOfTheSkin;
        }
        private bool IsJawStrengthValid(string jawStrength)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(jawStrength, pattern);
        }
        private bool IsColorOfTheSkinValid(string colorOfTheSkin)
        {

            string pattern = "^[A-Za-zА-Яа-я ]+$";
            return Regex.IsMatch(colorOfTheSkin, pattern);
        }
        public override void ShowProperties()
        {
            base.ShowProperties();

            Console.WriteLine($"Сила челюсти: {JawStrength}");

        }
        public override string ToString()
        {
            return $"Цвет кожи: {ColorOfTheSkin}";
        }
    }

}
