﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Prilozhenie_01
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Спр номен.
    /// </summary>
    // *** Start programmer edit section *** (СпрНомен CustomAttributes)

    // *** End programmer edit section *** (СпрНомен CustomAttributes)
    [AutoAltered()]
    [Caption("Справочник номенклатуры")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СпрНоменE", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "Описание as \'Описание\'",
            "СпрЕдИзмер as \'Единицы измерения\'",
            "СпрЕдИзмер.Наименование as \'Единицы измерения\'"})]
    [View("СпрНоменL", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "Описание as \'Описание\'",
            "СпрЕдИзмер.Наименование as \'Единицы измерения\'"})]
    public class СпрНомен : ICSSoft.STORMNET.DataObject
    {
        
        private int fКод;
        
        private string fНаименование;
        
        private string fОписание;
        
        private IIS.Prilozhenie_01.СпрЕдИзмер fСпрЕдИзмер;
        
        // *** Start programmer edit section *** (СпрНомен CustomMembers)

        // *** End programmer edit section *** (СпрНомен CustomMembers)

        
        /// <summary>
        /// Код.
        /// </summary>
        // *** Start programmer edit section *** (СпрНомен.Код CustomAttributes)

        // *** End programmer edit section *** (СпрНомен.Код CustomAttributes)
        public virtual int Код
        {
            get
            {
                // *** Start programmer edit section *** (СпрНомен.Код Get start)

                // *** End programmer edit section *** (СпрНомен.Код Get start)
                int result = this.fКод;
                // *** Start programmer edit section *** (СпрНомен.Код Get end)

                // *** End programmer edit section *** (СпрНомен.Код Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрНомен.Код Set start)

                // *** End programmer edit section *** (СпрНомен.Код Set start)
                this.fКод = value;
                // *** Start programmer edit section *** (СпрНомен.Код Set end)

                // *** End programmer edit section *** (СпрНомен.Код Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (СпрНомен.Наименование CustomAttributes)

        // *** End programmer edit section *** (СпрНомен.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (СпрНомен.Наименование Get start)

                // *** End programmer edit section *** (СпрНомен.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (СпрНомен.Наименование Get end)

                // *** End programmer edit section *** (СпрНомен.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрНомен.Наименование Set start)

                // *** End programmer edit section *** (СпрНомен.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (СпрНомен.Наименование Set end)

                // *** End programmer edit section *** (СпрНомен.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Описание.
        /// </summary>
        // *** Start programmer edit section *** (СпрНомен.Описание CustomAttributes)

        // *** End programmer edit section *** (СпрНомен.Описание CustomAttributes)
        [StrLen(255)]
        public virtual string Описание
        {
            get
            {
                // *** Start programmer edit section *** (СпрНомен.Описание Get start)

                // *** End programmer edit section *** (СпрНомен.Описание Get start)
                string result = this.fОписание;
                // *** Start programmer edit section *** (СпрНомен.Описание Get end)

                // *** End programmer edit section *** (СпрНомен.Описание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрНомен.Описание Set start)

                // *** End programmer edit section *** (СпрНомен.Описание Set start)
                this.fОписание = value;
                // *** Start programmer edit section *** (СпрНомен.Описание Set end)

                // *** End programmer edit section *** (СпрНомен.Описание Set end)
            }
        }
        
        /// <summary>
        /// Спр номен.
        /// </summary>
        // *** Start programmer edit section *** (СпрНомен.СпрЕдИзмер CustomAttributes)

        // *** End programmer edit section *** (СпрНомен.СпрЕдИзмер CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрЕдИзмер"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрЕдИзмер СпрЕдИзмер
        {
            get
            {
                // *** Start programmer edit section *** (СпрНомен.СпрЕдИзмер Get start)

                // *** End programmer edit section *** (СпрНомен.СпрЕдИзмер Get start)
                IIS.Prilozhenie_01.СпрЕдИзмер result = this.fСпрЕдИзмер;
                // *** Start programmer edit section *** (СпрНомен.СпрЕдИзмер Get end)

                // *** End programmer edit section *** (СпрНомен.СпрЕдИзмер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрНомен.СпрЕдИзмер Set start)

                // *** End programmer edit section *** (СпрНомен.СпрЕдИзмер Set start)
                this.fСпрЕдИзмер = value;
                // *** Start programmer edit section *** (СпрНомен.СпрЕдИзмер Set end)

                // *** End programmer edit section *** (СпрНомен.СпрЕдИзмер Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СпрНоменE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрНоменE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрНоменE", typeof(IIS.Prilozhenie_01.СпрНомен));
                }
            }
            
            /// <summary>
            /// "СпрНоменL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрНоменL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрНоменL", typeof(IIS.Prilozhenie_01.СпрНомен));
                }
            }
        }
    }
}
