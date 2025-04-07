﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Calc{
    internal class FV
    {
        public static double m = 0;

        public class Metal
        {
            public string Metals { get; set; }
            public string Name { get; set; }
            public double Density { get; set; }
            public string History { get; set; }
        }
        public static List<Metal> metal = new List<Metal>
        {
            new Metal {Metals = "Алюминий", Name = "1050", Density = 2.705, History = "Чистый алюминий, содержание Al не менее 99.5%. \nИспользуется в электротехнике и производстве фольги."},
            new Metal {Metals = "Алюминий", Name = "1060", Density = 2.705, History = "Чистый алюминий, содержание Al не менее 99.6%. \nПрименяется в производстве проводов и кабелей."},
            new Metal {Metals = "Алюминий", Name = "1100", Density = 2.71, History = "Чистый алюминий, содержание Al не менее 99.0%. \nШиркоко используется в пищевой упаковке и химической промышленности."},
            new Metal {Metals = "Алюминий", Name = "1145", Density = 2.70, History = "Чистый алюминий, содержание Al не менее 99.45%. \nПрименяется в производстве теплообменников."},
            new Metal {Metals = "Алюминий", Name = "1201", Density = 2.85, History = "Чистый алюминий, содержание Al не менее 99.9%. \nПрименяется в производстве высококачественных проводов."},
            new Metal {Metals = "Сталь", Name = "Ст3", Density = 7.85, History = "Углеродистая сталь с содержанием углерода до 0,15%. \nИспользуется для производства строительных конструкций и металлических изделий."},
            new Metal {Metals = "Сталь", Name = "45", Density = 7.85, History = "Углеродистая сталь с содержанием углерода около 0,45%. \nПрименяется для изготовления деталей машин и конструкций, требующих высокой прочности."},
            new Metal {Metals = "Сталь", Name = "15ХS", Density = 7.85, History = "Легированная сталь с добавлением хрома и углерода. \nИдеально подходит для производства высокопрочных деталей, работающих в условиях повышенной температуры."},
            new Metal {Metals = "Сталь", Name = "09Г2С", Density = 7.87, History = "Углеродистая сталь с добавлением марганца и серы. \nИспользуется для сварных конструкций и трубопроводов, работающих при низких температурах."},
            new Metal {Metals = "Сталь", Name = "12Х18Н10Т", Density = 8.0, History = "Нержавеющая сталь, содержащая хром, никель и титан. \nПрименяется в условиях, где требуется высокая коррозионная стойкость, в том числе в пищевой и химической промышленности."},
            new Metal {Metals = "Бронза", Name = "Бронза А1", Density = 8.3, History = "Легированная медь, содержащая около 90% меди и 10% олова. \nШироко используется для производства различных деталей, включая статуи и монеты."},
            new Metal {Metals = "Бронза", Name = "Бронза Б10", Density = 8.5, History = "Содержание меди примерно 85% и олова около 15%. \nИспользуется в машиностроении для изготовления подшипников и других деталей, работающих при трении."},
            new Metal {Metals = "Бронза", Name = "Бронза А3", Density = 8.7, History = "Содержит медь, олово и добавки, такие как фосфор и алюминий. \nПрименяется для электроники и производства высокопрочных деталей благодаря своей высокой коррозионной стойкости."},
            new Metal {Metals = "Бронза", Name = "Бронза А2", Density = 8.4, History = "Составляет около 88% меди и 12% олова, порой с добавлением других элементов. \nИспользуется в судостроении и для изготовления музыкальных инструментов, таких как трубы и саксофоны."},
            new Metal {Metals = "Бронза", Name = "Бронза CuSn", Density = 8.6, History = "Легированная медь с добавлением олова, содержание меди составляет около 92%. \nПрименяется в производстве пружин и деталей, работающих на износ, благодаря своей прочности и упругости."},
            new Metal {Metals = "Латунь", Name = "Л63", Density = 8.5, History = "Содержит около 63% меди и 37% цинка. \nШироко используется в производстве сантехники и сантехнических изделий, а также для создания деталей с высокой коррозионной стойкостью."},
            new Metal {Metals = "Латунь", Name = "Л68", Density = 8.4, History = "Содержит 68% меди и 32% цинка. \nПрименяется для изготовления деталей, где требуется высокая прочность и хорошая механическая обработка, таких как зубчатые колеса."},
            new Metal {Metals = "Латунь", Name = "Л70", Density = 8.6, History = "Содержит 70% меди и 30% цинка. \nИспользуется в электротехнике для производства контактов и задействуется в производстве музыкальных инструментов."},
            new Metal {Metals = "Латунь", Name = "Л90", Density = 8.7, History = "Содержит 90% меди и 10% цинка. \nПрименяется в ювелирном деле и для изготовления высококачественной художественной литейной продукции."},
            new Metal {Metals = "Латунь", Name = "Л52", Density = 8.3, History = "Содержит 52% меди и 48% цинка. \nШироко используется в машиностроении для производства деталей с хорошими антикоррозионными свойствами."},
            new Metal {Metals = "Медь", Name = "М1", Density = 8.96, History = "Чистая медь, содержание Cu не менее 99,9%. \nШироко используется в электротехнике для проводки и в производстве труб."},
            new Metal {Metals = "Медь", Name = "М0", Density = 8.89, History = "Содержание меди составляет не менее 99,7%. \nПрименяется в производстве электродов, а также в строительстве для создания кровельных материалов."},
            new Metal {Metals = "Медь", Name = "М2", Density = 8.92, History = "Содержит 99,5% меди с небольшими добавками других элементов. \nИспользуется в ювелирных изделиях и для изготовления монет."},
            new Metal {Metals = "Медь", Name = "М3", Density = 8.78, History = "Содержание меди 98,5%. \nИспользуется для создания сплавов с другими металлами, такими как латунь, и в промышленности."},
            new Metal {Metals = "Медь", Name = "М4", Density = 8.60, History = "Включает 98% меди и 2% других легирующих элементов. \nНайдёт применение в электрических машинах, а также для производства деталей трубопроводов."},
            new Metal {Metals = "Титан", Name = "Ti-6Al-4V", Density = 4.43, History = "Сплав титана с 90% титана, 6% алюминия и 4% ванадия. \nИспользуется в аэрокосмической промышленности из-за своей высокой прочности и легкости."},
            new Metal {Metals = "Титан", Name = "Ti-5Al-2.5Sn", Density = 4.51, History = "Содержит 90% титана, 5% алюминия и 2.5% олово. \nПрименяется в авиации и медицине для производства имплантатов благодаря своей биосовместимости."},
            new Metal {Metals = "Титан", Name = "Ti-6Al-2Sn-4Zr-6Mo", Density = 4.48, History = "Состоит из титана с добавлением 6% алюминия, 2% олова, 4% циркония и 6% молибдена. \nИспользуется в производстве деталей для реактивных двигателей и в морской технике."},
            new Metal {Metals = "Титан", Name = "Commercially Pure Titanium Grade 1", Density = 4.51, History = "Содержит около 99% титана с минимальными примесями. \nИспользуется в химической промышленности и в производстве элементов, подверженных коррозии."},
            new Metal {Metals = "Титан", Name = "Ti-3Al-2.5V", Density = 4.42, History = "Содержит 90% титана, 3% алюминия и 2.5% ванадия. \nПрименяется в аэрокосмической и спортивной отраслях для создания легких и прочных конструкций."},
            new Metal {Metals = "Чугун", Name = "GG20", Density = 7.0, History = "Отливка серого чугуна с углеродом в форме графита, содержащая около 2.5-4% углерода. \nИспользуется в производстве деталей машин, таких как корпуса и фланцы, благодаря хорошему литейному качеству."},
            new Metal {Metals = "Чугун", Name = "GJL-150", Density = 7.1, History = "Чугун с минимальным содержанием углерода 2.5-4% и прочностью на растяжение около 150 Н/мм². \nПрименяется для отливок, требующих хороших механических свойств, таких как трубы и требуемые детали."},
            new Metal {Metals = "Чугун", Name = "GJS-500", Density = 7.30, History = "Содержит около 3.4-4% углерода и обеспечивает высокую прочность благодаря наличию нодулярного графита. \nИспользуется в производстве деталей автомобильной и промышленной техники, таких как колеса и корпуса."},
            new Metal {Metals = "Чугун", Name = "GJSi-5", Density = 7.2, History = "Специальный чугун с добавлением кремния и углерода, который улучшает его коррозионную устойчивость. \nПрименяется в агрессивных средах, таких как насосы и водопроводные трубы."},
            new Metal {Metals = "Чугун", Name = "GJL-200", Density = 7.0, History = "Серый чугун с углеродом, которого содержится 2.5-4% и прочностью около 200 Н/мм². \nШироко используется в строительстве и для отливок, таких как колокола и статуи, благодаря своей хорошей текучести."},
            new Metal {Metals = "Цинк", Name = "Zinc 99.99", Density = 7.14, History = "Чистый цинк с содержанием Zn не менее 99,99%. \nПрименяется в производстве антикоррозионных покрытий и в электротехнике."},
            new Metal {Metals = "Цинк", Name = "Zinc 99.7", Density = 7.14, History = "Высококачественный цинк с содержанием Zn не менее 99,7%. \nИспользуется для горячего оцинковывания стали и в производстве сплавов."},
            new Metal {Metals = "Цинк", Name = "Zinc alloy Zamak 3", Density = 6.5, History = "Сплав цинка с алюминием, магнием и медью. \nПрименяется для литья под давлением в производстве мелких деталей и компонентов."},
            new Metal {Metals = "Цинк", Name = "Zinc Die Casting", Density = 7.0, History = "Специальный цинковый сплав, оптимизированный для литья. \nИспользуется в производстве сложных форм и деталей для промышленной техники."},
            new Metal {Metals = "Цинк", Name = "Zinc 90-10", Density = 7.2, History = "Сплав цинка с 10% меди, обладающий повышенной прочностью. \nПрименяется в производстве сокращающих и анодных блоков для защиты от коррозии."},
            new Metal {Metals = "Сталь", Name = "AISI 304", Density = 7.93, History = "Нержавеющая сталь, содержащая около 18% хрома и 8% никеля. \nИспользуется в производстве кухонной утвари, труб и конструкций, требующих высокой коррозионной стойкости."},
            new Metal {Metals = "Сталь", Name = "AISI 316", Density = 7.98, History = "Содержит около 16% хрома и 10% никеля, а также 2% молибдена для улучшенной коррозионной стойкости. \nЭто часто используется в морской и химической промышленности, где требуется высокая защита от коррозии."},
            new Metal {Metals = "Сталь", Name = "AISI 430", Density = 7.75, History = "Это нержавеющая сталь с содержанием около 17% хрома, но без никеля. \nПрименяется в производстве кухонной мебели, вытяжек и в архитектурных целях."},
            new Metal {Metals = "Сталь", Name = "AISI 410", Density = 7.7, History = "Нержавеющая сталь с около 12% хрома, обеспечивающей умеренную коррозионную стойкость. \nИспользуется в производстве режущих инструментов, сгибов и различных деталей."},
            new Metal {Metals = "Сталь", Name = "AISI 321", Density = 7.98, History = "Сталь с содержанием хрома около 17% и никеля около 9%, дополненная титаном для устойчивости к коррозии. \nИспользуется в высокотемпературных применениях, таких как ракеты, спутники и реакторы."}
        };
    }
}

