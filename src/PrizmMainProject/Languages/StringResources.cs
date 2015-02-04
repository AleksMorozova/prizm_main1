using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Languages
{
    static class StringResources
    {
        public static StringResource TestString = new StringResource { Id = "Test_String", Description = "Проверочная строка. Нигде не используется." };

        #region --- Common strings like Active - Not active, Hold - Witness, etc. Messages.
        // to be used on different forms
        public static StringResource FirstEnterDate = new StringResource
        {
            Id = "FirstEnterDate",
            Description = "Вначале необходимо ввести дату"
        };
        
        public static StringResource JointSearch_ActivityCriteria_StatusActive = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusActive",
            Description = "Активные"
        };
                
        public static StringResource JointSearch_ActivityCriteria_StatusUnactive = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusUnactive",
            Description = "Неактивные"
        };
                        
        public static StringResource JointSearch_ActivityCriteria_StatusAll = new StringResource {
            Id = "JointSearch_ActivityCriteria_StatusAll",
            Description = "Все"
        };
                   
        public static StringResource JointSearch_JointStatus_Welded = new StringResource {
            Id = "JointSearch_JointStatus_Welded",
            Description = "Сварен"
        };
                                        
        public static StringResource JointSearch_JointStatus_Lowered = new StringResource {
            Id = "JointSearch_JointStatus_Lowered",
            Description = "Уложен"
        };
                                             
        public static StringResource JointSearch_JointStatus_Withdrawn = new StringResource {
            Id = "JointSearch_JointStatus_Withdrawn",
            Description = "Вырезан"
        };

        public static StringResource JointNewEdit_JointStatus_Undefined = new StringResource
        {
            Id = "JointNewEdit_JointStatus_Undefined",
            Description = "Неопределен"
        };        

        public static StringResource AppSplashScreen_VersionLabel = new StringResource
        {
            Id = "AppSplashScreen_VersionLabel",
            Description = "Текст перед версией программы на всплывающем окне при загрузке программы"
        };

        #region --- PartType ---
        public static StringResource PartTypePipe = new StringResource { 
            Id = "PartTypePipe", 
            Description = "Надпись типа элемента Труба"};

        public static StringResource PartTypeSpool = new StringResource { 
            Id = "PartTypeSpool", 
            Description = "Надпись типа элемента Катушка"};

        public static StringResource PartTypeComponent = new StringResource { 
            Id = "PartTypeComponent", 
            Description = "Надпись типа элемента Компонент"};

        public static StringResource PartTypeUndefined = new StringResource
        {
            Id = "PartTypeUndefined",
            Description = "Надпись типа элемента Неопределен"
        };

        #endregion

        #region --- Activity ---
        public static StringResource StatusActive = new StringResource { 
            Id = "StatusActive", 
            Description = "Надпись статуса активности элемента Активен"};

        public static StringResource StatusInactive = new StringResource { 
            Id = "StatusInactive", 
            Description = "Надпись статуса активности элемента Неактивен"};

        public static StringResource StatusAll = new StringResource { 
            Id = "StatusAll", 
            Description = "Надпись статуса активности элемента Все"};
        #endregion

        public static StringResource Value_Required = new StringResource
        {
            Id = "Value_Required",
            Description = "Значение обязательно"
        };

        #region --- Test result types ---
        public static StringResource TestResultTypeBoolean = new StringResource { 
            Id = "TestResultTypeBoolean", 
            Description = "Тип результата контрольной операции. Логический"};

        public static StringResource TestResultTypeRange = new StringResource { 
            Id = "TestResultTypeRange", 
            Description = "Тип результата контрольной операции. Диапазон"};

        public static StringResource TestResultTypeString = new StringResource { 
            Id = "TestResultTypeString", 
            Description = "Тип результата контрольной операции. Строка"};
        #endregion


        #region --- Test control type ---
        public static StringResource ControlTypeWitness = new StringResource { 
            Id = "ControlTypeWitness",
            Description = "Вид контроля. Освидетельствование"};

        public static StringResource ControlTypeReview = new StringResource { 
            Id = "ControlTypeReview",
            Description = "Вид контроля. Проверка документов"};

        public static StringResource ControlTypeMonitor = new StringResource { 
            Id = "ControlTypeMonitor", 
            Description = "Вид контроля. Мониторинг"};

        public static StringResource ControlTypeHold = new StringResource { 
            Id = "ControlTypeHold", 
            Description = "Вид контроля. Обязательная проверка"};
        #endregion

        #region --- PartInspectionStatus ---
        public static StringResource PartInspectionStatus_Undefined = new StringResource
        {
            Id = "PartInspectionStatus_Undefined",
            Description = "Статус на входном контроле. Неопределен"
        };

        public static StringResource PartInspectionStatus_Pending = new StringResource
        {
            Id = "PartInspectionStatus_Pending",
            Description = "Статус на входном контроле. Ожидается"
        };

        public static StringResource PartInspectionStatus_Hold = new StringResource
        {
            Id = "PartInspectionStatus_Hold",
            Description = "Статус на входном контроле. Задержан"
        };

        public static StringResource PartInspectionStatus_Rejected = new StringResource
        {
            Id = "PartInspectionStatus_Rejected",
            Description = "Статус на входном контроле. Отклонено"
        };

        public static StringResource PartInspectionStatus_Accepted = new StringResource
        {
            Id = "PartInspectionStatus_Accepted",
            Description = "Статус на входном контроле. Принято"
        };
        #endregion


        #region --- Workstation types ---
        public static StringResource WorkstationType_Undefined = new StringResource
        {
            Id = "WorkstationType_Undefined",
            Description = "Тип рабочей станции. Неопределен"
        };

        public static StringResource WorkstationType_Master = new StringResource
        {
            Id = "WorkstationType_Master",
            Description = "Тип рабочей станции. Главный"
        };

        public static StringResource WorkstationType_Mill= new StringResource
        {
            Id = "WorkstationType_Mill",
            Description = "Тип рабочей станции. Завод"
        };
        
        public static StringResource WorkstationType_Construction = new StringResource
        {
            Id = "WorkstationType_Construction",
            Description = "Тип рабочей станции. Строительство"
        };
        #endregion

        //messages 
        public static StringResource Message_ErrorHeader = new StringResource
        {
            Id = "Message_ErrorHeader",
            Description = "Универсальный заголовок сообщения об ошибке: Ошибка"
        };

        public static StringResource Message_AuthentificationFailed = new StringResource
        {
            Id = "Message_AuthentificationFailed",
            Description = "Сообщение при логине: Неверное имя пользователя или пароль."
        };

        public static StringResource Message_AuthentificationFailedUserInactive = new StringResource
        {
            Id = "Message_AuthentificationFailedUserInactive",
            Description = "Сообщение при логине: Вход для пользователя {0} заблокирован"
        };

        public static StringResource Message_ComponentDeactivationQuestionHeader = new StringResource
        {
            Id = "Message_ComponentDeactivationQuestionHeader",
            Description = "Заголовок вопроса о подтверждении деактивации компонента"
        };

        public static StringResource Message_ComponentDeactivationQuestion = new StringResource
        {
            Id = "Message_ComponentDeactivationQuestion",
            Description = "Вопрос о подтверждении деактивации компонента: Данное действие приведет к деактивации комплектующего элемента.  Параметры комплектующего элемента станут невозможны для редактирования. Деактивировать комплектующий элемент?"
        };

        public static StringResource PartInspection_InspectionsSaved = new StringResource
        {
            Id = "PartInspection_InspectionsSaved",
            Description = "Результаты контрольных операций успешно сохранены. Номер элемента: "
        };

        public static StringResource PartInspection_InspectionsSavedHeader = new StringResource
        {
            Id = "PartInspection_InspectionsSavedHeader",
            Description = "Сохранение контрольных операций"
        };

        public static StringResource ExternalFiles_FileAttachSuccess = new StringResource
        {
            Id = "ExternalFiles_FileAttachSuccess",
            Description = "Вложения успешно добавлены"
        };

        public static StringResource ExternalFiles_FileAttachSuccessHeader = new StringResource
        {
            Id = "ExternalFiles_FileAttachSuccessHeader",
            Description = "Добавление вложений"
        };

        public static StringResource ExternalFiles_FileDownloadHeader = new StringResource
        {
            Id = "ExternalFiles_FileDownloadHeader",
            Description = "Загрузка файла"
        };

        public static StringResource ExternalFiles_FileDownloadSuccess = new StringResource
        {
            Id = "ExternalFiles_FileDownloadSuccess",
            Description = "Файл успешно загружен"
        };

        public static StringResource ExternalFiles_FileViewDownloadFail = new StringResource
        {
            Id = "ExternalFiles_FileViewDownloadFail",
            Description = "Для просмотра и скачивания вложений необходимо их предварительное сохранение"
        };

        public static StringResource ExternalFiles_NotCopied = new StringResource
        {
            Id = "ExternalFiles_NotCopied",
            Description = "Прикрепленные файлы не сохранены"
        };

        public static StringResource ExternalFiles_NotCopied_Header = new StringResource
        {
            Id = "ExternalFiles_NotCopied_Header",
            Description = "Ошибка сохранения прикрепленных файлов"
        };

        public static StringResource ExternalFiles_FileViewDownloadFailHeader = new StringResource
        {
            Id = "ExternalFiles_FileViewDownloadFailHeader",
            Description = "Просмотр и загрузка несохрaненных файлов"
        };


        public static StringResource Yes = new StringResource
        {
            Id = "Yes",
            Description = "Да"
        };

        public static StringResource No = new StringResource
        {
            Id = "No",
            Description = "Нет"
        };

         public static StringResource DateFirst = new StringResource
        {
            Id = "DateFirst",
            Description = "Сообщение об ошибке: Выберите дату"
        };

         public static StringResource Validation_ValueRequired = new StringResource
         {
             Id = "Validation_ValueRequired",
             Description = "Сообщение об ошибке: Значение обязательно"
         };

         public static StringResource Validation_UniqueValueRequired = new StringResource
         {
             Id = "Validation_UniqueValueRequired",
             Description = "Сообщение об ошибке: Введите уникальное значение"
         };

         public static StringResource Message_DeleteRecord = new StringResource
         {
             Id = "Message_DeleteRecord",
             Description = "Вопрос об удалении записи: Удалить запись?"
         };

         public static StringResource Message_NoMoreDocumentsCanOpen = new StringResource
         {
             Id = "Message_NoMoreDocumentsCanOpen",
             Description = "Сообщение: Нельзя одновременно открыть больше документов."
         };

         public static StringResource Alert_InfoHeader = new StringResource
         {
             Id = "Alert_InfoHeader",
             Description = "Заголовок для информационного сообщения: Внимание"
         };

         public static StringResource Message_FailureReportDate = new StringResource
         {
             Id = "Message_FailureReportDate",
             Description = "Сообщение об ошибке запуска отчёта: Начальная дата позже конечной"
         };

         public static StringResource Message_FailureReportDateHeader = new StringResource
         {
             Id = "Message_FailureReportDateHeader",
             Description = "Заголовок для ошибки запуска отчёта: Неверный диапазон дат"
         };



        #endregion // --- Common

         #region --- Main Window ---

         public static StringResource MainWindowHeader_Title = new StringResource
         {
             Id = "MainWindowHeader_Title",
             Description = "Сокращённое название программы: PRISM v.2"
         };

         public static StringResource MainWindowHeader_Construction = new StringResource
         {
             Id = "MainWindowHeader_Construction",
             Description = "Название рабочей станции: Строительство"
         };

         public static StringResource MainWindowHeader_Master = new StringResource
         {
             Id = "MainWindowHeader_Master",
             Description = "Название рабочей станции: Главный"
         };

         public static StringResource MainWindowHeader_Mill = new StringResource
         {
             Id = "MainWindowHeader_Mill",
             Description = "Название рабочей станции: Завод"
         };

         public static StringResource MainWindow_CloseEditingReleaseNote = new StringResource
         {
             Id = "MainWindow_CloseEditingReleaseNote",
             Description = "Сообщение: Пожалуйста сначала закройте редактируемое разрешение на отгрузку"
         };

         public static StringResource MainWindow_OpenReleaseNoteReadOnly = new StringResource
         {
             Id = "MainWindow_OpenReleaseNoteReadOnly",
             Description = "Сообщение: Форма Разрешение на отгрузку уже открыта, хотите открыть разрешение в режиме просмотра?"
         };

         #endregion //--- Main Window ---

        #region PurchaseOrderForm
         //message
        public static StringResource PurchaseOrder_ValueRequired = new StringResource
        {
            Id = "PurchaseOrder_ValueRequaered",
            Description = "Обязательное значение"
        };
        public static StringResource PurchaseOrder_ErrorHeader = new StringResource
        {
            Id = "PurchaseOrder_ErrorHeader",
            Description = "Ошибка создания наряд-заказа"
        };

        public static StringResource PurchaseOrder_NumberLabel = new StringResource
        {
            Id = "PurchaseOrder_NumberLabel",
            Description = "Наряд-заказ. Надпись над полем номера"
        };

        public static StringResource PurchaseOrder_DateLabel = new StringResource
        {
            Id = "PurchaseOrder_DateLabel",
            Description = "Наряд-заказ. Надпись над полем даты"
        };
        public static StringResource PurchaseOrder_SaveButton = new StringResource
        {
            Id = "PurchaseOrder_SaveButton",
            Description = "Наряд-заказ.Кнопка сохранения"
        };
        public static StringResource PurchaseOrder_CancelButton = new StringResource
        {
            Id = "PurchaseOrder_CancelButton",
            Description = "Наряд-заказ.Кнопка отмены"
        };
        #endregion PurchaseOrderForm

        #region PasswordChange
        public static StringResource PassChange_OldPassLabel = new StringResource
        {
            Id = "PassChange_OldPassLabel",
            Description = "Смена пароля. Ввод старого пароля"
        };

        public static StringResource PassChange_PassLabel = new StringResource
        {
            Id = "PassChange_PassLabel",
            Description = "Смена пароля. Ввод нового пароля"
        };

        public static StringResource PassChange_ConfirmPassLabel = new StringResource
        {
            Id = "PassChange_ConfirmPassLabel",
            Description = "Смена пароля. Подтверждение пароля"
        };

        public static StringResource PassChange_OKButton = new StringResource
        {
            Id = "PassChange_OKButton",
            Description = "Смена пароля. Кнопка подтверждения"
        };

        public static StringResource PassChange_CancelButton = new StringResource
        {
            Id = "PassChange_CancelButton",
            Description = "Смена пароля. Кнопка отмены"
        };

        public static StringResource PassChange_InvalidOldPassword = new StringResource
        {
            Id = "PassChange_InvalidOldPassword",
            Description = "Сообщение об ошибке: Текущий пароль введен неверно."
        };

        public static StringResource PassChange_PasswordsNotMatch = new StringResource
        {
            Id = "PassChange_PasswordsNotMatch",
            Description = "Сообщение об ошибке: Пароли не совпадают."
        };

        #endregion PasswordChange

        #region MillReport
        public static StringResource MillReport_ReportTypesLabel = new StringResource
        {
            Id = "MillReport_ReportTypesLabel",
            Description = "Отчеты на заводе. Выбор типа отчета"
        };

        public static StringResource MillReport_ReportPeriodLabel = new StringResource
        {
            Id = "MillReport_ReportPeriodLabel",
            Description = "Отчеты на заводе. Период формирования отчета"
        };
        public static StringResource MillReport_StartDateLabel = new StringResource
        {
            Id = "MillReport_StartDateLabel",
            Description = "Отчеты на заводе. Начальная дата"
        };

        public static StringResource MillReport_EndDateLabel = new StringResource
        {
            Id = "MillReport_EndDateLabel",
            Description = "Отчеты на заводе. Конечная дата"
        };

        public static StringResource MillReport_CategoriesLabel = new StringResource
        {
            Id = "MillReport_CategoriesLabel",
            Description = "Отчеты на заводе. Категория контрольной операции"
        };

        public static StringResource MillReport_StatusesLabel = new StringResource
        {
            Id = "MillReport_StatusesLabel",
            Description = "Отчеты на заводе. Статус контрольной операции"
        };
        public static StringResource MillReport_CreateGroup = new StringResource
        {
            Id = "MillReport_CreateGroup",
            Description = "Отчеты на заводе. Создание отчета"
        };
        public static StringResource MillReport_PreviewGroup = new StringResource
        {
            Id = "MillReport_PreviewGroup",
            Description = "Отчеты на заводе. Просмотр отчета"
        };

        public static StringResource MillReport_CreateButton = new StringResource
        {
            Id = "MillReport_CreateButton",
            Description = "Отчеты на заводе. Кнопка создания отчета"
        };

        public static StringResource MillReport_PreviewButton = new StringResource
        {
            Id = "MillReport_PreviewButton",
            Description = "Отчеты на заводе. Кнопка предпросмотра отчета"
        };
        public static StringResource MillReport_TypeByCategories = new StringResource
        {
            Id = "MillReport_TypeByCategories",
            Description = "Отчеты на заводе. Тип отчета - По категориям"
        };
        public static StringResource MillReport_TypeByShipped = new StringResource
        {
            Id = "MillReport_TypeByShipped",
            Description = "Отчеты на заводе. Тип отчета - По Отгруженным"
        };
        public static StringResource MillReport_TypeByProduced = new StringResource
        {
            Id = "MillReport_TypeByProduced",
            Description = "Отчеты на заводе. Тип отчета - ПО произведенным"
        };
        public static StringResource MillReport_TypeGeneral = new StringResource
        {
            Id = "MillReport_TypeGeneral",
            Description = "Отчеты на заводе. Тип отчета - Общий отчет"
        };
        #endregion MillReport

        #region IncomingInspectionReport
        public static StringResource InspectionReport_DateLabel = new StringResource
        {
            Id = "InspectionReport_DateLabel",
            Description = "Период для формирования отчета"
        };

        public static StringResource InspectionReport_StartDateLabel = new StringResource
        {
            Id = "InspectionReport_StartDateLabel",
            Description = "Отчет на входном контроле. Начальная дата"
        };

        public static StringResource InspectionReport_EndDateLabel = new StringResource
        {
            Id = "InspectionReport_EndDateLabel",
            Description = "Отчет на входном контроле. Крнечная дата"
        };

        public static StringResource InspectionReport_CreateGroup = new StringResource
        {
            Id = "InspectionReport_CreateGroup",
            Description = "Отчет на входном контроле. Создание отчета"
        };

        public static StringResource InspectionReport_PreviewGroup = new StringResource
        {
            Id = "InspectionReport_PreviewGroup",
            Description = "Отчет на входном контроле. Предпросмотр отчета"
        };

        public static StringResource InspectionReport_PreviewButton = new StringResource
        {
            Id = "InspectionReport_PreviewButton",
            Description = "Отчет на входном контроле. Кнопка предпросмотра отчета"
        };

        public static StringResource InspectionReport_CreateButton = new StringResource
        {
            Id = "InspectionReport_CreateButton",
            Description = "Отчет на входном контроле. Кнопка создания отчета"
        };
        #endregion IncomingInspectionReport

        #region Spool
        //message
        public static StringResource Spool_SpoolLengtBigerThenPipeLength = new StringResource
        {
            Id = "Spool_SpoolLengtBigerThenPipeLength",
            Description = "Длина трубы меньше длины катушки"
        };
        public static StringResource Spool_CutSpoolFromPipe = new StringResource
        {
            Id = "Spool_CutSpoolFromPipe",
            Description = "Катушка успешно отрезана"
        };
        public static StringResource Spool_CutSpoolFromPipeHeader = new StringResource
        {
            Id = "Spool_CutSpoolFromPipeHeader",
            Description = "Заголовок орезания катушки"
        };
        public static StringResource Spool_NullSpoolLength = new StringResource
        {
            Id = "Spool_NullSpoolLength",
            Description = "Длина катушки равна 0"
        };
        public static StringResource Spool_WrongPipeNumberForCutting = new StringResource
        {
            Id = "Spool_WrongPipeNumberForCutting",
            Description = "Неверный номер трубы для нарезания на катушки"
        };
        public static StringResource Spool_WrongPipeNumberForCuttingHeader = new StringResource
        {
            Id = "Spool_WrongPipeNumberForCuttingHeader",
            Description = "Неверный номер трубы для нарезания на катушки"
        };
        public static StringResource Spool_PipeNumberLabel = new StringResource
        {
            Id = "Spool_PipeNumberLabel",
            Description = "Катушка. Номер трубы для нарезания на кутушки"
        };

        public static StringResource Spool_SpoolNumberLabel = new StringResource
        {
            Id = "Spool_SpoolNumberLabel",
            Description = "Катушка. Номер катушки"
        };

        public static StringResource Spool_PipeLengthLabel = new StringResource
        {
            Id = "Spool_PipeLengthLabel",
            Description = "Катушка. Длина трубы"
        };

        public static StringResource Spool_SpoolLengthLabel = new StringResource
        {
            Id = "Spool_SpoolLengthLabel",
            Description = "Катушка. Длина катушки"
        };

        public static StringResource Spool_PipeSearchGroup = new StringResource
        {
            Id = "Spool_PipeSearchGroup",
            Description = "Катушка. Поиск трубы"
        };

        public static StringResource Spool_SpoolGroup = new StringResource
        {
            Id = "Spool_SpoolGroup",
            Description = "Катушка. Данные о катушке"
        };

        public static StringResource Spool_LenghtGroup = new StringResource
        {
            Id = "Spool_LenghtGroup",
            Description = "Катушка. Длины трубы и катушки"
        };

        public static StringResource Spool_InspectionDateColumn = new StringResource
        {
            Id = "Spool_InspectionDateColumn",
            Description = "Катушка. Дата входного контроля"
        };

        public static StringResource Spool_InspectionResultColumn = new StringResource
        {
            Id = "Spool_InspectionResultColumn",
            Description = "Катушка. Результат входного контроля"
        };

        public static StringResource Spool_InspectionInspectorsColumn = new StringResource
        {
            Id = "Spool_InspectionInspectorsColumn",
            Description = "Катушка. Инспектора"
        };

        public static StringResource Spool_InspectionReasonColumn = new StringResource
        {
            Id = "Spool_InspectionReasonColumn",
            Description = "Катушка. Комментарии по результату входного контроля"
        };

        public static StringResource Spool_SearchButton = new StringResource
        {
            Id = "Spool_SearchButton",
            Description = "Катушка. Кнопка поиска трубы"
        };

        public static StringResource Spool_AttachButton = new StringResource
        {
            Id = "Spool_AttachButton",
            Description = "Катушка. Кнопка вложений"
        };

        public static StringResource Spool_SaveButton = new StringResource
        {
            Id = "Spool_SaveButton",
            Description = "Катушка. Кнопка сохранения"
        };

        public static StringResource Spool_DeactivatedCheckBox = new StringResource
        {
            Id = "Spool_DeactivatedCheckBox",
            Description = "Катушка. Деактивация катушки"
        };

        public static StringResource Spool_DeactivationQuestion = new StringResource
        {
            Id = "Spool_DeactivationQuestion",
            Description = "Катушка, вопрос о деактивации: Данное действие приведет к деактивации катушки: длина исходной трубы будет пересчитана, параметры катушки станут невозможны для редактирования. Если катушка содержит брак, вместо деактивации рекомендуем присвоить ей соответствующий статус на входном контроле. Деактивировать комплектующий элемент?"
        };

        public static StringResource Spool_DeactivationQuestionHeader = new StringResource
        {
            Id = "Spool_DeactivationQuestionHeader",
            Description = "Катушка, заголовок вопроса о деактивации: Деактивация катушки"
        };

        public static StringResource Spool_EditDocumentHeader = new StringResource
        {
            Id = "Spool_EditDocumentHeader",
            Description = "Катушка, заголовок окна редактирования: Редактирование катушки"
        };
        

        #endregion Spool

        #region MissingPortion
        public static StringResource MissingPortion_missingNumbers = new StringResource
        {
            Id = "MissingPortion_missingNumbers",
            Description = "Недостающие порции. Номера порций"
        };

        public static StringResource MissingPortion_recomendation= new StringResource
        {
            Id = "MissingPortion_recomendation",
            Description = "Недостающие порции. Рекомендации"
        };

        public static StringResource MissingPortion_acceptButton = new StringResource
        {
            Id = "MissingPortion_acceptButton",
            Description = "Недостающие порции. Кнопка подтверждения импорта"
        };

        public static StringResource MissingPortion_cancelButton = new StringResource
        {
            Id = "MissingPortion_cancelButton",
            Description = "Недостающие порции. Кнопка отмены импорта"
        };
        #endregion MissingPortion

        #region Settings
        //message
        public static StringResource  Settings_ValidateInspectorSertificate = new StringResource
        {
            Id = "Settings_ValidateInspectorSertificate",
            Description = "Для ввода сертификата необходимо выбрать инспектора"
        };
        public static StringResource Settings_ValueRequired = new StringResource
        {
            Id = "Settings_ValueRequaered",
            Description = "Обязательное значение"
        };
        public static StringResource Settings_UniqueValueRequired = new StringResource
        {
            Id = "Settings_UniqueValueRequired",
            Description = "Значение должно быть уникальным"
        };
        public static StringResource Settings_ChekControlOperations = new StringResource
        {
            Id = "Settings_ChekControlOperations",
            Description = "Необходимо проверить контрольную операцию"
        };
        public static StringResource Settings_DateExpired = new StringResource
        {
            Id = "Settings_DateExpired",
            Description = "Дата сертификата просрочена"
        };

        public static StringResource Settings_ErrorHeader = new StringResource
        {
            Id = "Settings_ErrorHeader",
            Description = "Заголовок ошибки"
        };
        public static StringResource Settings_CheckValues = new StringResource
        {
            Id = "Settings_CheckValues",
            Description = "Необходимо проверить значение"
        };
        public static StringResource Settings_SetupSavedHeader = new StringResource
        {
            Id = "Settings_SetupSavedHeader",
            Description = "Заголовок успешного сохранения настроек"
        };
        public static StringResource Settings_SetupSaves = new StringResource
        {
            Id = "Settings_SetupSaves",
            Description = "Настройки сохранены"
        };
        //setting form
        public static StringResource Settings_ProjectTab = new StringResource
        {
            Id = "Settings_ProjectTab",
            Description = "Настройки. Вкладка - Проект"
        };
        public static StringResource Settings_PipeTab = new StringResource
        {
            Id = "Settings_PipeTab",
            Description = "Настройки. Вкладка - Труба"
        };
        public static StringResource Settings_LineTab = new StringResource
        {
            Id = "Settings_LineTab",
            Description = "Настройки. Вкладка - Трубопровод"
        };
        public static StringResource Settings_PartsTab = new StringResource
        {
            Id = "Settings_PartsTab",
            Description = "Настройки. Вкладка - Комплектующие"
        };
        public static StringResource Settings_WeldersTab = new StringResource
        {
            Id = "Settings_WeldersTab",
            Description = "Настройки. Вкладка - Сварщики"
        };

        public static StringResource Settings_InspectorsTab = new StringResource
        {
            Id = "Settings_InspectorsTab",
            Description = "Настройки. Вкладка - Инспектора"
        };

        public static StringResource Settings_UsersTab = new StringResource
        {
            Id = "Settings_UsersTab",
            Description = "Настройки. Вкладка - Пользователи"
        };
        public static StringResource Settings_RolesTab = new StringResource
        {
            Id = "Settings_RolesTab",
            Description = "Настройки. Вкладка - Роли"
        };
        public static StringResource Settings_SaveButton = new StringResource
        {
            Id = "Settings_SaveButton",
            Description = "Настройки. Кнопка - Сохранить"
        };
        public static StringResource Settings_CloseButton = new StringResource
        {
            Id = "Settings_CloseButton",
            Description = "Настройки. Кнопка - Закрыть"
        };

        //project page
        public static StringResource SettingsProject_TitleLabel = new StringResource
        {
            Id = "SettingsProject_TitleLabel",
            Description = "Настройки-Проект. Название проекта"
        };
        public static StringResource SettingsProject_ClientLabel = new StringResource
        {
            Id = "SettingsProject_ClientLabel",
            Description = "Настройки-Проект. Имя заказчика"
        };
        public static StringResource SettingsProject_PlateManufacturerLabel = new StringResource
        {
            Id = "SettingsProject_PlateManufacturerLabel",
            Description = "Настройки-Проект. Список производителей листов"
        };
        public static StringResource SettingsProject_DocumentSizeLabel = new StringResource
        {
            Id = "SettingsProject_DocumentSizeLabel",
            Description = "Настройки-Проект. Максимальный размер документа"
        };
        public static StringResource SettingsProject_MillLabel = new StringResource
        {
            Id = "SettingsProject_MillLabel",
            Description = "Настройки-Проект. Название завода"
        };
        public static StringResource SettingsProject_MaskEditLabel = new StringResource
        {
            Id = "SettingsProject_MaskEditLabel",
            Description = "Настройки-Проект. Маска номера трубы"
        };

        public static StringResource MillPipeNumber_Mask_Hint = new StringResource
        {
            Id = "MillPipeNumber_Mask_Hint",
            Description = "Текст подсказки формата номера трубы: Формат номера трубы: "
        };

        public static StringResource SettingsProject_OperationsLabel = new StringResource
        {
            Id = "SettingsProject_OperationsLabel",
            Description = "Настройки-Проект. Группы контрольных операций"
        };
        public static StringResource SettingsProject_SeamsLabel = new StringResource
        {
            Id = "SettingsProject_SeamsLabel",
            Description = "Настройки-Проект. Типы швов"
        };
        public static StringResource SettingsProject_CommonGroup = new StringResource
        {
            Id = "SettingsProject_CommonGroup",
            Description = "Настройки-Проект. Общие настройки"
        };
        public static StringResource SettingsProject_MillGroup = new StringResource
        {
            Id = "SettingsProject_MillGroup",
            Description = "Настройки-Проект. Настройки для завода"
        };
        public static StringResource SettingsProject_PlateManColumn = new StringResource
        {
            Id = "SettingsProject_PlateManColumn",
            Description = "Настройки-Проект. Производители листов-колонка"
        };

        public static StringResource SettingsProject_InspectionsCategoryColumn = new StringResource
        {
            Id = "SettingsProject_InspectionsCategoryColumn",
            Description = "Настройки-Проект. Название категорий контрольных операций"
        };
        public static StringResource SettingsProject_InspectionsIsActiveColumn = new StringResource
        {
            Id = "SettingsProject_InspectionsIsActiveColumn",
            Description = "Настройки-Проект. Активность категории контрольной операции"
        };
        public static StringResource SettingsProject_SeamTypeColumn = new StringResource
        {
            Id = "SettingsProject_SeamTypeColumn",
            Description = "Настройки-Проект. Название типов швов"
        };
        public static StringResource SettingsProject_SeamIsActiveColumn = new StringResource
        {
            Id = "SettingsProject_SeamIsActiveColumn",
            Description = "Настройки-Проект. Активность типа шва"
        };

        //pipe page
        public static StringResource SettingsPipe_SizesLabel = new StringResource
        {
            Id = "SettingsPipe_SizesLabel",
            Description = "Настройки-труба. Параметры типоразмера"
        };

        public static StringResource SettingsPipe_InspectionsLabel = new StringResource
        {
            Id = "SettingsPipe_InspectionsLabel",
            Description = "Настройки-труба. Контрольные операции для типоразмера"
        };
        public static StringResource SettingsPipe_DiameterLabel = new StringResource
        {
            Id = "SettingsPipe_DiameterLabel",
            Description = "Настройки-труба. Диаметр трубы с заданым типоразмером"
        };
        public static StringResource SettingsPipe_WallThicknessLabel = new StringResource
        {
            Id = "SettingsPipe_WallThicknessLabel",
            Description = "Настройки-труба. Толщина стенки для трубы с заданым типоразмером"
        };
        public static StringResource SettingsPipe_LengthLabel = new StringResource
        {
            Id = "SettingsPipe_LengthLabel",
            Description = "Настройки-труба. Длина трубы для заданного типоразмера"
        };
        public static StringResource SettingsPipe_SeamTypeLabel = new StringResource
        {
            Id = "SettingsPipe_SeamTypeLabel",
            Description = "Настройки-труба. Тип шва для заданого типоразмера"
        };
        
        public static StringResource SettingsPipe_CloneTypeSizeButton = new StringResource
        {
            Id = "SettingsPipe_CloneTypeSizeButton",
            Description = "Настройки-труба. Кнопка клонировать типоразмер"
        };
        public static StringResource SettingsPipe_AddTestButton = new StringResource
        {
            Id = "SettingsPipe_AddTestButton",
            Description = "Настройки-труба. Кнопка добавить контрольную операцию"
        };
        public static StringResource SettingsPipe_EditTestButton = new StringResource
        {
            Id = "SettingsPipe_EditTestButton",
            Description = "Настройки-труба. Кнопка редактировать контрольную операцию"
        };

        public static StringResource SettingsPipe_SizeGridColumn = new StringResource
        {
            Id = "SettingsPipe_SizeGridColumn",
            Description = "Настройки-труба. Список типоразеров"
        };
        public static StringResource SettingsPipe_SizeIsActiveGridColumn = new StringResource
        {
            Id = "SettingsPipe_SizeIsActiveGridColumn",
            Description = "Настройки-труба. Активность типоразмера"
        };
        
        public static StringResource SettingsPipe_InspectionsCodeColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsCodeColumn",
            Description = "Настройки-труба. Код контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsNameColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsNameColumn",
            Description = "Настройки-труба. Название контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsCategoryColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsCategoryColumn",
            Description = "Настройки-труба. Категория контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsControlTypeColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsControlTypeColumn",
            Description = "Настройки-труба. Тип контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsResultTypeColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsResultTypeColumn",
            Description = "Настройки-труба. Результат контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsBoolExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsBoolExpectedColumn",
            Description = "Настройки-труба. Ожидаемый результат для булевского результата"
        };
        
        public static StringResource SettingsPipe_InspectionsMinExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsMinExpectedColumn",
            Description = "Настройки-труба. Минимальный результат контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsMaxExpectedColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsMaxExpectedColumn",
            Description = "Настройки-труба. Максимальный результат контрольной операции"
        };
        
        public static StringResource SettingsPipe_InspectionsIsReqiredColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsIsReqiredColumn",
            Description = "Настройки-труба. Обязательная контрольная операция"
        };
        
        public static StringResource SettingsPipe_InspectionsIsActiveColumn = new StringResource
        {
            Id = "SettingsPipe_InspectionsIsActiveColumn",
            Description = "Настройки-труба. Активность контрольной операции"
        };
        
        //pipeline page
        public static StringResource SettingsLine_LineGroup = new StringResource
        {
            Id = "SettingsLine_LineGroup",
            Description = "Настройки - Трубопровод. Список контрольных и ремонтных операций для стыка"
        };

        public static StringResource SettingsLine_NameColumn = new StringResource
        {
            Id = "SettingsLine_NameColumn",
            Description = "Настройки - Трубопровод. Название операции"
        };

        public static StringResource SettingsLine_IsReqiredColumn = new StringResource
        {
            Id = "SettingsLine_IsReqiredColumn",
            Description = "Настройки - Трубопровод. Обязательная операция"
        };

        public static StringResource SettingsLine_TestTypeColumn = new StringResource
        {
            Id = "SettingsLine_TestTypeColumn",
            Description = "Настройки - Трубопровод. Тип операции"
        };

        public static StringResource SettingsLine_HasAcceptedColumn = new StringResource
        {
            Id = "SettingsLine_HasAcceptedColumn",
            Description = "Настройки - Трубопровод. Результат контроля - Принято"
        };

        public static StringResource SettingsLine_RepairColumn = new StringResource
        {
            Id = "SettingsLine_RepairColumn",
            Description = "Настройки - Трубопровод. Результат контроля - Ремонт"
        };

        public static StringResource SettingsLine_WithdrawColumn = new StringResource
        {
            Id = "SettingsLine_WithdrawColumn",
            Description = "Настройки - Трубопровод. Результат контроля - Вырезка"
        };

        public static StringResource SettingsLine_IsReqiredResultColumn = new StringResource
        {
            Id = "SettingsLine_IsReqiredResultColumn",
            Description = "Настройки - Трубопровод. Обязательный результат контрольной операции"
        };

        public static StringResource SettingsLine_IsActiveColumn = new StringResource
        {
            Id = "SettingsLine_IsActiveColumn",
            Description = "Настройки - Трубопровод. Активность операции"
        };

        //component page

        public static StringResource SettingsComponent_PartsType = new StringResource
        {
            Id = "SettingsComponent_PartsType",
            Description = "Настройки - Комплектующие. Список типов комплектующих изделий"
        };

        public static StringResource SettingsComponent_TypeColumn = new StringResource
        {
            Id = "SettingsComponent_TypeColumn",
            Description = "Настройки - Комплектующие. Тип комплектующего"
        };

        public static StringResource SettingsComponent_ConnectorsNumberColumn = new StringResource
        {
            Id = "SettingsComponent_ConnectorsNumberColumn",
            Description = "Настройки - Комплектующие. Количество коннекторов у комплектующего"
        };

        public static StringResource SettingsComponent_IsActiveTypeColumn = new StringResource
        {
            Id = "SettingsComponent_IsActiveTypeColumn",
            Description = "Настройки - Комплектующие. Активность комплектующего элемента"
        };

        //welder page
        public static StringResource SettingsWelders_LastNameColumn = new StringResource
        {
            Id = "SettingsWelders_LastNameColumn",
            Description = "Настройки - Сварщики. Фамилия сварщика"
        };
        public static StringResource SettingsWelders_FirstNameColumn = new StringResource
        {
            Id = "SettingsWelders_FirstNameColumn",
            Description = "Настройки - Сварщики. Имя сварщика"
        };
        public static StringResource SettingsWelders_MiddleNameColumn = new StringResource
        {
            Id = "SettingsWelders_MiddleNameColumn",
            Description = "Настройки - Сварщики. Отчество сварщика"
        };
        public static StringResource SettingsWelders_CertificateNameColumn = new StringResource
        {
            Id = "SettingsWelders_CertificateNameColumn",
            Description = "Настройки - Сварщики. Сертификат сварщика"
        };
        public static StringResource SettingsWelders_ExpiredColumn = new StringResource
        {
            Id = "SettingsWelders_ExpiredColumn",
            Description = "Настройки - Сварщики. Срок действия сертификата"
        };
        public static StringResource SettingsWelders_StampColumn = new StringResource
        {
            Id = "SettingsWelders_StampColumn",
            Description = "Настройки - Сварщики. Клеймо сварщика"
        };
        public static StringResource SettingsWelders_GradeColumn = new StringResource
        {
            Id = "SettingsWelders_GradeColumn",
            Description = "Настройки - Сварщики. Уровень сварщика"
        };
        public static StringResource SettingsWelders_IsActiveColumn = new StringResource
        {
            Id = "SettingsWelders_IsActiveColumn",
            Description = "Настройки - Сварщики. Активность сварщика"
        };

        //inspectors page
        public static StringResource SettingsInspectors_InspectorsLabel = new StringResource
        {
            Id = "SettingsInspectors_InspectorsLabel",
            Description = "Настройки - Инспектора. Список инспекторов"
        };
        public static StringResource SettingsInspectors_CertificatesLabel = new StringResource
        {
            Id = "SettingsInspectors_CertificatesLabel",
            Description = "Настройки - Инспектора. Список сертификатов для конкретного инспектора"
        };
        public static StringResource SettingsInspectors_CertificateTypesLabel = new StringResource
        {
            Id = "SettingsInspectors_CertificateTypesLabel",
            Description = "Настройки - Инспектора. Типы сертификатов"
        };
        public static StringResource SettingsInspectors_InspectorsGroup = new StringResource
        {
            Id = "SettingsInspectors_InspectorsGroup",
            Description = "Настройки - Инспектора. Информация по всем инспекторам"
        };
        public static StringResource SettingsInspectors_CertificatesGroup = new StringResource
        {
            Id = "SettingsInspectors_CertificatesGroup",
            Description = "Настройки - Инспектора. Информация по всем сертификатам"
        };

        public static StringResource SettingsInspectors_LastNameColumn = new StringResource
        {
            Id = "SettingsInspectors_LastNameColumn",
            Description = "Настройки - Инспектора. Фамилия инспектора"
        };
        public static StringResource SettingsInspectors_FirstNameColumn = new StringResource
        {
            Id = "SettingsInspectors_FirstNameColumn",
            Description = "Настройки - Инспектора. Имя инспектора"
        };
        public static StringResource SettingsInspectors_MiddleNameColumn = new StringResource
        {
            Id = "SettingsInspectors_MiddleNameColumn",
            Description = "Настройки - Инспектора. Отчество инспектора"
        };

        public static StringResource SettingsInspectors_CertificateNumberColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateNumberColumn",
            Description = "Настройки - Инспектора. Номер сертификата инспектора"
        };
        public static StringResource SettingsInspectors_CertificateTypeColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateTypeColumn",
            Description = "Настройки - Инспектора. Тип сертификата"
        };
        public static StringResource SettingsInspectors_CertificateExpirationColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateExpirationColumn",
            Description = "Настройки - Инспектора. Срок дейстия сертификата инспектора"
        };

        public static StringResource SettingsInspectors_CertificateIsActiveColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateIsActiveColumn",
            Description = "Настройки - Инспектора. Активность типа сертификата"
        };
        public static StringResource SettingsInspectors_CertificateNameColumn = new StringResource
        {
            Id = "SettingsInspectors_CertificateNameColumn",
            Description = "Настройки - Инспектора. Название типа сертификата инспектора"
        };

        // user page

        public static StringResource SettingsUser_UsersLabel = new StringResource
        {
            Id = "SettingsUser_UsersLabel",
            Description = "Настройки - Пользователи. Список пользователей"
        };
        public static StringResource SettingsUser_LoginColumn = new StringResource
        {
            Id = "SettingsUser_LoginColumn",
            Description = "Настройки - Пользователи. Логин пользователя"
        };
        public static StringResource SettingsUser_LastNameColumn = new StringResource
        {
            Id = "SettingsUser_LastNameColumn",
            Description = "Настройки - Пользователи. Фамилия пользователя"
        };
        public static StringResource SettingsUser_MiddleNameColumn = new StringResource
        {
            Id = "SettingsUser_MiddleNameColumn",
            Description = "Настройки - Пользователи. Отчество пользователя"
        };
        public static StringResource SettingsUser_FirstNameColumn = new StringResource
        {
            Id = "SettingsUser_FirstNameColumn",
            Description = "Настройки - Пользователи. Имя пользователя"
        };
        public static StringResource SettingsUser_PassExpiredColumn = new StringResource
        {
            Id = "SettingsUser_PassExpiredColumn",
            Description = "Настройки - Пользователи. Срок истечения пароля"
        };
        public static StringResource SettingsUser_IsActiveColumn = new StringResource
        {
            Id = "SettingsUser_IsActiveColumn",
            Description = "Настройки - Пользователи.  Активность пользователя"
        };
        public static StringResource SettingsUser_PassColumn = new StringResource
        {
            Id = "SettingsUser_PassColumn",
            Description = "Настройки - Пользователи. Пароль пользователя"
        };

        //role page
        public static StringResource SettingsRoles_Label = new StringResource
        {
            Id = "SettingsRoles_Label",
            Description = "Настройки - Роли. Список ролей"
        };
        public static StringResource SettingsRoles_PermissionLabel = new StringResource
        {
            Id = "SettingsRoles_PermissionLabel",
            Description = "Настройки - Роли. Права для конкретной роли"
        };
        public static StringResource SettingsRole_NameColumn = new StringResource
        {
            Id = "SettingsRole_NameColumn",
            Description = "Настройки - Роли. Название роли"
        };

        public static StringResource SettingsRole_DescriptionColumn = new StringResource
        {
            Id = "SettingsRole_DescriptionColumn",
            Description = "Настройки - Роли. Описание роли"
        };

        public static StringResource SecurityPrivilege_Audit = new StringResource
        {
            Id = "SecurityPrivilege_Audit",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateComponent = new StringResource
        {
            Id = "SecurityPrivilege_CreateComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateJoint = new StringResource
        {
            Id = "SecurityPrivilege_CreateJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreatePipe = new StringResource
        {
            Id = "SecurityPrivilege_CreatePipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateReleaseNote = new StringResource
        {
            Id = "SecurityPrivilege_CreateReleaseNote",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_CreateSpool = new StringResource
        {
            Id = "SecurityPrivilege_CreateSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivateComponent = new StringResource
        {
            Id = "SecurityPrivilege_DeactivateComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivateJoint = new StringResource
        {
            Id = "SecurityPrivilege_DeactivateJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivatePipe = new StringResource
        {
            Id = "SecurityPrivilege_DeactivatePipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_DeactivateSpool = new StringResource
        {
            Id = "SecurityPrivilege_DeactivateSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditComponent = new StringResource
        {
            Id = "SecurityPrivilege_EditComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditJoint = new StringResource
        {
            Id = "SecurityPrivilege_EditJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditPipe = new StringResource
        {
            Id = "SecurityPrivilege_EditPipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditReleaseNote = new StringResource
        {
            Id = "SecurityPrivilege_EditReleaseNote",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditSettings = new StringResource
        {
            Id = "SecurityPrivilege_EditSettings",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_EditSpool = new StringResource
        {
            Id = "SecurityPrivilege_EditSpool",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ExportDataFromConstruction = new StringResource
        {
            Id = "SecurityPrivilege_ExportDataFromConstruction",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ExportDataFromMaster = new StringResource
        {
            Id = "SecurityPrivilege_ExportDataFromMaster",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ExportDataFromMill = new StringResource
        {
            Id = "SecurityPrivilege_ExportDataFromMill",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ImportData = new StringResource
        {
            Id = "SecurityPrivilege_ImportData",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ImportDataAtConstruction = new StringResource
        {
            Id = "SecurityPrivilege_ImportDataAtConstruction",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ImportDataAtMaster = new StringResource
        {
            Id = "SecurityPrivilege_ImportDataAtMaster",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PartsInspection = new StringResource
        {
            Id = "SecurityPrivilege_PartsInspection",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintConstructionReports = new StringResource
        {
            Id = "SecurityPrivilege_PrintConstructionReports",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintInspectionReports = new StringResource
        {
            Id = "SecurityPrivilege_PrintInspectionReports",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_PrintMillReports = new StringResource
        {
            Id = "SecurityPrivilege_PrintMillReports",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ReleaseNotes = new StringResource
        {
            Id = "SecurityPrivilege_ReleaseNotes",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchJoints = new StringResource
        {
            Id = "SecurityPrivilege_SearchJoints",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchParts = new StringResource
        {
            Id = "SecurityPrivilege_SearchParts",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchPipes = new StringResource
        {
            Id = "SecurityPrivilege_SearchPipes",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_SearchReleaseNotes = new StringResource
        {
            Id = "SecurityPrivilege_SearchReleaseNotes",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_UnshipAtMill = new StringResource
        {
            Id = "SecurityPrivilege_UnshipAtMill",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewComponent = new StringResource
        {
            Id = "SecurityPrivilege_ViewComponent",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewJoint = new StringResource
        {
            Id = "SecurityPrivilege_ViewJoint",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewPipe = new StringResource
        {
            Id = "SecurityPrivilege_ViewPipe",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewReleaseNote = new StringResource
        {
            Id = "SecurityPrivilege_ViewReleaseNote",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewSettings = new StringResource
        {
            Id = "SecurityPrivilege_ViewSettings",
            Description = "Название соответствующей привилегии доступа"
        };

        public static StringResource SecurityPrivilege_ViewSpool = new StringResource
        {
            Id = "SecurityPrivilege_ViewSpool",
            Description = "Название соответствующей привилегии доступа"
        };


        #endregion Settings

        #region --- Audit ---

        public static StringResource Audit_ElementNumberLabel = new StringResource {
            Id = "Audit_ElementNumberLabel",
            Description = "Аудит. Надпись номера элемента."};
        
        public static StringResource Audit_PeriodLabel = new StringResource { 
            Id = "Audit_PeriodLabel", 
            Description = "Аудит. Надпись периода"};

        public static StringResource Audit_StartDateLabel = new StringResource { 
            Id = "Audit_StartDateLabel", 
            Description = "Аудит. Надпись начальной даты)"};

        public static StringResource Audit_EndDateLabel = new StringResource { 
            Id = "Audit_EndDateLabel", 
            Description = "Аудит. Надпись конечной даты)"};

        public static StringResource Audit_UserLabel = new StringResource { 
            Id = "Audit_UserLabel", 
            Description = "Аудит. Надпись пользователя"};

        public static StringResource Audit_SearchButton = new StringResource { 
            Id = "Audit_SearchButton", 
            Description = "Аудит. Надпись кнопки пользователя"};

        public static StringResource Audit_UserColumnHeader = new StringResource { 
            Id = "Audit_UserColumnHeader", 
            Description = "Аудит. Надпись колонки пользователя"};

        public static StringResource Audit_DateColumnHeader = new StringResource { 
            Id = "Audit_DateColumnHeader", 
            Description = "Аудит. Надпись колонки даты"};

        public static StringResource Audit_EntityColumnHeader = new StringResource { 
            Id = "Audit_EntityColumnHeader", 
            Description = "Аудит. Надпись колонки изменяемой сущности"};

        public static StringResource Audit_OldValueColumnHeader = new StringResource { 
            Id = "Audit_OldValueColumnHeader", 
            Description = "Аудит. Надпись колонки старого значения"};

        public static StringResource Audit_NewValueColumnHeader = new StringResource { 
            Id = "Audit_NewValueColumnHeader",
            Description = "Аудит. Надпись колонки нового значения" };

        public static StringResource Audit_FieldColumnHeader = new StringResource { 
            Id = "Audit_FieldColumnHeader", 
            Description = "Аудит. Надпись колонки поля"};

        public static StringResource Audit_NumberColumnHeader = new StringResource { 
            Id = "Audit_NumberColumnHeader", 
            Description = "Аудит. Надпись колонки номера"};

        public static StringResource Audit_SearchParametersGroup = new StringResource { 
            Id = "Audit_SearchParametersGroup", 
            Description = "Аудит. Надпись панели параметров поиска"};

        public static StringResource Audit_RadioPeriod = new StringResource { 
            Id = "Audit_RadioPeriod", 
            Description = "Аудит. Надпись радиокнопки периода"};

        public static StringResource Audit_RadioUser = new StringResource { 
            Id = "Audit_RadioUser", 
            Description = "Аудит. Надпись радиокнопки пользователя"};

        #endregion //--- Audit --

        #region --- About ---

        public static StringResource AboutForm_TitleLabel = new StringResource {
            Id = "AboutForm_TitleLabel",
            Description = "Текст в окне \"О программе \""
        };
        public static StringResource About_VersionLabel = new StringResource
        {
            Id = "About_VersionLabel",
            Description = "Текст перед версией программы в окне \"О программе \""
        };
        public static StringResource About_AcceptButton = new StringResource
        {
            Id = "About_AcceptButton",
            Description = "Кнопка ОК"
        };
        #endregion // --- About ---

        #region --- Part Search ---

        public static StringResource PartSearch_SearchNumberLabel = new StringResource { 
            Id = "PartSearch_SearchNumberLabel",
            Description = "Поиск элементов трубопровода. Надпись номера элемента"};

        public static StringResource PartSearch_SearchTypeLabel = new StringResource { 
            Id = "PartSearch_SearchTypeLabel", 
            Description = "Поиск элементов трубопровода. Надпись типа элемента"};

        public static StringResource PartSearch_ActivityLabel = new StringResource { 
            Id = "PartSearch_ActivityLabel", 
            Description = "Поиск элементов трубопровода. Надпись активности элемента"};

        public static StringResource PartSearch_SearchButton = new StringResource {
            Id = "PartSearch_SearchButton", 
            Description = "Поиск элементов трубопровода. Надпись кнопки поиска"};

        public static StringResource PartSearch_NumberColumnHeader = new StringResource { 
            Id = "PartSearch_NumberColumnHeader", 
            Description = "Поиск элементов трубопровода. Надпись колонки номера"};

        public static StringResource PartSearch_TypeColumnHeader = new StringResource { 
            Id = "PartSearch_TypeColumnHeader", 
            Description = "Поиск элементов трубопровода. Надпись колонки типа"};

        public static StringResource PartSearch_SearchGroup = new StringResource { 
            Id = "PartSearch_SearchGroup", 
            Description = "Поиск элементов трубопровода. Надпись панели поиска"};

        public static StringResource PartSearch_SearchResultGroup = new StringResource { 
            Id = "PartSearch_SearchResultGroup", 
            Description = "Поиск элементов трубопровода. Надпись панели результатов поиска"};


        #endregion

        #region --- Export/Import ---

        public static StringResource Export_Ready = new StringResource
        {
            Id = "Export_Ready",
            Description = "Сообщение об успехе экспорта: Экспортирование завершено успешно."
        };

        public static StringResource Export_ExportButton = new StringResource { 
            Id = "Export_ExportButton", 
            Description = "Экспорт. Надпись кнопки экспорта"};

        public static StringResource Export_PleaseWaitPanel = new StringResource { 
            Id = "Export_PleaseWaitPanel", 
            Description = "Экспорт. Надпись панели загрузки Ожидайте"};

        public static StringResource Export_ExportingData = new StringResource { 
            Id = "Export_ExportingData", 
            Description = "Экспорт. Надпись панели загрузки экспортирование"};
        
        public static StringResource Export_LogLabel = new StringResource { 
            Id = "Export_LogLabel", 
            Description = "Экспорт. Надпись надписи журнала"};

        public static StringResource Export_ReexportButton = new StringResource { 
            Id = "Export_ReexportButton", 
            Description = "Экспорт. Надпись кнопки реэкспорта"};

        public static StringResource Export_PortionIdColumnHeader = new StringResource {
            Id = "Export_PortionIdColumnHeader", 
            Description = "Экспорт. Надпись колонки Id порции"};

        public static StringResource Export_ExportDateColumnHeader = new StringResource { 
            Id = "Export_ExportDateColumnHeader", 
            Description = "Экспорт. Надпись колонки даты экспорта"};

        public static StringResource Export_LogTab = new StringResource { 
            Id = "Export_LogTab",
            Description = "Экспорт. Надпись вкладки журнала"};

        public static StringResource Export_HistoryTab = new StringResource { 
            Id = "Export_HistoryTab",
            Description = "Экспорт. Надпись вкладки истории"};

        public static StringResource Export_ArchiveExported = new StringResource
        {
            Id = "Export_ArchiveExported",
            Description = "[{0}] Экспортировано в '{1}'"
        };

        public static StringResource Export_CreateTempStorage = new StringResource
        {
            Id = "Export_CreateTempStorage",
            Description = "Создание временного хранилища."
        };

        public static StringResource Export_CreatingArchive = new StringResource
        {
            Id = "Export_CreatingArchive",
            Description = "Создание конечного архива."
        };

        public static StringResource Export_Error = new StringResource
        {
            Id = "Export_Error",
            Description = "[{0}] Ошибка {1}"
        };

        public static StringResource Export_Filter = new StringResource
        {
            Id = "Export_Filter",
            Description = "PRIZM archives|*.prizm"
        };

        public static StringResource Export_NoData = new StringResource
        {
            Id = "Export_NoData",
            Description = "Нет новых данных для экспортирования."
        };

        public static StringResource Export_ReadingData = new StringResource
        {
            Id = "Export_ReadingData",
            Description = "Чтение данных."
        };

        public static StringResource Export_WritingData = new StringResource
        {
            Id = "Export_WritingData",
            Description = "Экспортирование завершено успешно."
        };

        public static StringResource Import_Checksum = new StringResource
        {
            Id = "Import_Checksum",
            Description = "Проверка контрольной суммы"
        };

        public static StringResource Import_Conflict = new StringResource
        {
            Id = "Import_Conflict",
            Description = "Труба с номером '{0}' уже существует в БД."
        };

        public static StringResource Import_CopyAttachments = new StringResource
        {
            Id = "Import_CopyAttachments",
            Description = "Импорт вложений"
        };

        public static StringResource Import_Data = new StringResource
        {
            Id = "Import_Data",
            Description = "Импорт данных"
        };

        public static StringResource Import_SamePortion = new StringResource
        {
            Id = "Import_SamePortion",
            Description = "Данная порция уже была импортирована и не может быть импортирована снова."
        };

        public static StringResource Import_TempStorage = new StringResource
        {
            Id = "Import_TempStorage",
            Description = "Создание временного хранилища"
        };

        public static StringResource Import_Unzip = new StringResource
        {
            Id = "Import_Unzip",
            Description = "Распаковкаа"
        };

        #endregion // --- Export/Import ---

        #region ---Save Dialog---
        public static StringResource SaveDialog_SaveLabel = new StringResource { 
            Id = "SaveDialog_SaveLabel", 
            Description = "Диалог сохранения. Текст"};

        public static StringResource SaveDialog_SaveButton = new StringResource { 
            Id = "SaveDialog_SaveButton", 
            Description = "Диалог сохранения. Кнопка сохранения"};

        public static StringResource SaveDialog_DontSaveButton = new StringResource { 
            Id = "SaveDialog_DontSaveButton", 
            Description = "Диалог сохранения. Кнопка Не сохранять"};

        public static StringResource SaveDialog_CancelButton = new StringResource { 
            Id = "SaveDialog_CancelButton", 
            Description = "Диалог сохранения. Кнопка отмены"};


        #endregion

        #region --- External files ---
        public static StringResource ExternalFiles_AddFileButton = new StringResource { 
            Id = "ExternalFiles_AddFileButton", 
            Description = "Вложения. Кнопка добавления"};

        public static StringResource ExternalFiles_FileNameColumnHeader = new StringResource { 
            Id = "ExternalFiles_FileNameColumnHeader", 
            Description = "Вложения. Надпись колонки имени файла"};

        public static StringResource ExternalFiles_UploadDateColumnHeader = new StringResource { 
            Id = "ExternalFiles_UploadDateColumnHeader", 
            Description = "Вложения. Надпись колонки даты загрузки"};

        #endregion

        #region --- CreateSpoolComponentDialog ---
        public static StringResource CreateSpoolComponentDialog_CreateElementQuestionLabel = new StringResource {
            Id = "CreateSpoolComponentDialog_CreateElementQuestionLabel", 
            Description = "Диалог создания элемента. Текст вопроса"};

        public static StringResource CreateSpoolComponentDialog_RadioSpool = new StringResource { 
            Id = "CreateSpoolComponentDialog_RadioSpool", 
            Description = "Диалог создания элемента. Радиокнопка катушки"};

        public static StringResource CreateSpoolComponentDialog_RadioComponent = new StringResource { 
            Id = "CreateSpoolComponentDialog_RadioComponent", 
            Description = "Диалог создания элемента. Радиокнопка комплектующего"};

        public static StringResource CreateSpoolComponentDialog_CancelButton = new StringResource {
            Id = "CreateSpoolComponentDialog_CancelButton", 
            Description = "Диалог создания элемента. Кнопка отмены"};

        public static StringResource CreateSpoolComponentDialog_CreateButton = new StringResource { 
            Id = "CreateSpoolComponentDialog_CreateButton", 
            Description = "Диалог создания элемента. Кнопка создания"};
        #endregion

        #region --- InspectionSelectPartDialog ---
        public static StringResource InspectionSelectPartDialog_SearchResultsLabel = new StringResource { 
            Id = "InspectionSelectPartDialog_SearchResultsLabel", 
            Description = "Диалог выбора элемента инспекции. Надпись результатов поиска"};

        public static StringResource InspectionSelectPartDialog_CancelButton = new StringResource { 
            Id = "InspectionSelectPartDialog_CancelButton", Description = 
            "Диалог выбора элемента инспекции. Надпись кнопки отмены"};

        public static StringResource InspectionSelectPartDialog_InspectionButton = new StringResource { 
            Id = "InspectionSelectPartDialog_InspectionButton", 
            Description = "Диалог выбора элемента инспекции. Надпись кнопки контроля"};

        public static StringResource InspectionSelectPartDialog_NumberColumnHeader = new StringResource { 
            Id = "InspectionSelectPartDialog_NumberColumnHeader", 
            Description = "Диалог выбора элемента инспекции. Надпись колонки номера"};

        public static StringResource InspectionSelectPartDialog_TypeColumnHeader = new StringResource { 
            Id = "InspectionSelectPartDialog_TypeColumnHeader", 
            Description = "Диалог выбора элемента инспекции. Надпись колонки типа"};

        #endregion

        #region ---Conflict Dialog
        public static StringResource ConflictDialog_ConflictLabel = new StringResource { 
            Id = "ConflictDialog_ConflictLabel", 
            Description = "Диалог конфликта при импорте. Текст"};

        public static StringResource ConflictDialog_ReplaceButton = new StringResource { 
            Id = "ConflictDialog_ReplaceButton", 
            Description = "Диалог конфликта при импорте. Надпись кнопки замены"};

        public static StringResource ConflictDialog_SkipButton = new StringResource { 
            Id = "ConflictDialog_SkipButton", 
            Description = "Диалог конфликта при импорте. Надпись кнопки Пропустить"};

        public static StringResource ConflictDialog_PostponeButton = new StringResource {
            Id = "ConflictDialog_PostponeButton", 
            Description = "Диалог конфликта при импорте. Надпись кнопки отложения решения"};

        public static StringResource ConflictDialog_ApplyForAllChechbox = new StringResource { 
            Id = "ConflictDialog_ApplyForAllChechbox", 
            Description = "Диалог конфликта при импорте. Надпись чекбокса Применить для всех"};

        #endregion

        #region --- Import form ---
        public static StringResource Import_ArchiveLabel = new StringResource { 
            Id = "Import_ArchiveLabel", 
            Description = "Импорт. Надпись архива"};

        public static StringResource Import_BrowseButton = new StringResource { 
            Id = "Import_BrowseButton", 
            Description = "Импорт. Надпись кнопки поиска"};

        public static StringResource Import_ImportButton = new StringResource { 
            Id = "Import_ImportButton", 
            Description = "Импорт. Надпись кнопки импорта"};

        #endregion

        #region --- Heat Number Form ---
        public static StringResource HeatNumber_HeatNumberLabel = new StringResource { 
            Id = "HeatNumber_HeatNumberLabel", 
            Description = "Номер плавки. Надпись номера"};

        public static StringResource HeatNumber_SaveButton = new StringResource { 
            Id = "HeatNumber_SaveButton", 
            Description = "Номер плавки. Надпись кнопки сохранения"};

        public static StringResource HeatNumber_CancelButton = new StringResource { Id = 
            "HeatNumber_CancelButton", 
            Description = "Номер плавки. Надпись кнопки отмены"};

        #endregion

        #region --- ComponentNewEdit ---

        public static StringResource ComponentNewEdit_NewComponentLayoutGroup = new StringResource
        {
            Id = "ComponentNewEdit_NewComponentLayoutGroup",
            Description = "Комплектующее изделие"
        };

        public static StringResource ComponentNewEdit_ComponentNumberLayout = new StringResource
        {
            Id = "ComponentNewEdit_ComponentNumberLayout",
            Description = "Ном&ер изделия"
        };

        public static StringResource ComponentNewEdit_TypeLayoutControl = new StringResource
        {
            Id = "ComponentNewEdit_TypeLayoutControl",
            Description = "&Тип изделия"
        };

        public static StringResource ComponentNewEdit_CertificateLayout = new StringResource
        {
            Id = "ComponentNewEdit_CertificateLayout",
            Description = "Номер се&ртификата"
        };

        public static StringResource ComponentNewEdit_ComponentLengthLayout = new StringResource
        {
            Id = "ComponentNewEdit_ComponentLengthLayout",
            Description = "Длина комплектую&щего, мм"
        };

        public static StringResource ComponentNewEdit_AttachmentsButton = new StringResource
        {
            Id = "ComponentNewEdit_AttachmentsButton",
            Description = "&Вложения"
        };

        public static StringResource ComponentNewEdit_Deactivated = new StringResource
        {
            Id = "ComponentNewEdit_Deactivated",
            Description = "Компонент деактивирован"
        };

        public static StringResource ComponentNewEdit_NewSaveComponentButton = new StringResource
        {
            Id = "ComponentNewEdit_NewSaveComponentButton",
            Description = "Со&хранить / Создать"
        };

        public static StringResource ComponentNewEdit_SaveComponentButton = new StringResource
        {
            Id = "ComponentNewEdit_SaveComponentButton",
            Description = "&Сохранить"
        };

        public static StringResource ComponentNewEdit_InspectionDateColumn = new StringResource
        {
            Id = "ComponentNewEdit_InspectionDateColumn",
            Description = "Дата инспекции"
        };

        public static StringResource ComponentNewEdit_InspectorColumn = new StringResource
        {
            Id = "ComponentNewEdit_InspectorColumn",
            Description = "Инспекторы"
        };

        public static StringResource ComponentNewEdit_ResultColumn = new StringResource
        {
            Id = "ComponentNewEdit_ResultColumn",
            Description = "Результат"
        };

        public static StringResource ComponentNewEdit_ReasonColumn = new StringResource
        {
            Id = "ComponentNewEdit_ReasonColumn",
            Description = "Причина"
        };

        public static StringResource ComponentNewEdit_DiameterGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_DiameterGridColumn",
            Description = "Диаметр отверстия"
        };

        public static StringResource ComponentNewEdit_WallThicknessGridColumn = new StringResource
        {
            Id = "ComponentNewEdit_WallThicknessGridColumn",
            Description = "Толщина стенки"
        };

        public static StringResource ComponentNewEdit_InspectionLayoutGroup = new StringResource
        {
            Id = "ComponentNewEdit_InspectionLayoutGroup",
            Description = "Входно&й контроль"
        };

        public static StringResource ComponentNewEdit_Duplicate = new StringResource
        {
            Id = "ComponentNewEdit_Duplicate",
            Description = "Сообщение о существующем номере: Уже существует комплектующий элемент с номером:"
        };

        public static StringResource ComponentNewEdit_DuplicateHeader = new StringResource
        {
            Id = "ComponentNewEdit_DuplicateHeader",
            Description = "Заголовок сообщения о существующем номере: Дублирование номера комплектующего элемента"
        };

        public static StringResource ComponentNewEdit_Saved = new StringResource
        {
            Id = "ComponentNewEdit_Saved",
            Description = "Сообщение о сохранении существующего элемента: Комплектующее изделие успешно сохранено в базе. Комплектующее изделие #"
        };

        public static StringResource ComponentNewEdit_SavedHeader = new StringResource
        {
            Id = "ComponentNewEdit_SavedHeader",
            Description = "Заголовок сообщения о сохранении существующего элемента"
        };

        public static StringResource ComponentNewEdit_DiameterValueValidation = new StringResource
        {
            Id = "ComponentNewEdit_DiameterValueValidation",
            Description = "Сообщение об ошибке: Величина диаметра должна быть больше нуля"
        };

        #endregion //--- ComponentNewEdit ---

        #region --- JointNew ---

        public static StringResource JointNew_JointNumberLayout = new StringResource
        {
            Id = "JointNew_JointNumberLayout",
            Description = "Ном&ер стыка"
        };

        public static StringResource JointNew_JointStatusLayout = new StringResource
        {
            Id = "JointNew_JointStatusLayout",
            Description = "Статус стыка"
        };

        public static StringResource JointNew_FirstJointElementLayout = new StringResource
        {
            Id = "JointNew_FirstJointElementLayout",
            Description = "&Первый элемент стыка"
        };

        public static StringResource JointNew_SecondJointElementLayout = new StringResource
        {
            Id = "JointNew_SecondJointElementLayout",
            Description = "В&торой элемент стыка"
        };

        public static StringResource JointNew_JointParametersLayoutGroup = new StringResource
        {
            Id = "JointNew_JointParametersLayoutGroup",
            Description = "Параметры стыка"
        };

        public static StringResource JointNew_LoweringLayoutGroup = new StringResource
        {
            Id = "JointNew_LoweringLayoutGroup",
            Description = "Параметры укладки"
        };

        public static StringResource JointNew_LoweringDateLayout = new StringResource
        {
            Id = "JointNew_LoweringDateLayout",
            Description = "Дата &укладки"
        };

        public static StringResource JointNew_PKLabelLayout = new StringResource
        {
            Id = "JointNew_PKLabelLayout",
            Description = "PK"
        };

        public static StringResource JointNew_PKNumberLayout = new StringResource
        {
            Id = "JointNew_PKNumberLayout",
            Description = "Номер п&икета"
        };

        public static StringResource JointNew_DistanceFromPKLayout = new StringResource
        {
            Id = "JointNew_DistanceFromPKLayout",
            Description = "Рассто&яние от пикета"
        };

        public static StringResource JointNew_GPSLabelLayout = new StringResource
        {
            Id = "JointNew_GPSLabelLayout",
            Description = "GPSLabelLayout"
        };

        public static StringResource JointNew_GPSLatLayout = new StringResource
        {
            Id = "JointNew_GPSLatLayout",
            Description = "&Широта"
        };

        public static StringResource JointNew_GPSLongLayout = new StringResource
        {
            Id = "JointNew_GPSLongLayout",
            Description = "До&лгота"
        };

        public static StringResource JointNew_ElevationLayout = new StringResource
        {
            Id = "JointNew_ElevationLayout",
            Description = "В&ысота"
        };

        public static StringResource JointNew_InspectionLayoutGroup = new StringResource
        {
            Id = "JointNew_InspectionLayoutGroup",
            Description = "Операции"
        };

        public static StringResource JointNew_RepairOperationLayout = new StringResource
        {
            Id = "JointNew_RepairOperationLayout",
            Description = "Сварка и ре&монт"
        };

        public static StringResource JointNew_ControlOperationsLayout = new StringResource
        {
            Id = "JointNew_ControlOperationsLayout",
            Description = "Контрольные опера&ции"
        };

        public static StringResource JointNew_SaveButton = new StringResource
        {
            Id = "JointNew_SaveButton",
            Description = "Со&хранить"
        };

        public static StringResource JointNew_SaveAndCreateButton = new StringResource
        {
            Id = "JointNew_SaveAndCreateButton",
            Description = "Сох&ранить/Создать"
        };

        public static StringResource JointNew_ExtraFiles = new StringResource
        {
            Id = "JointNew_ExtraFiles",
            Description = "&Вложения"
        };

        public static StringResource JointNew_Deactivated = new StringResource
        {
            Id = "JointNew_Deactivated",
            Description = "Стык деактивирован"
        };

        public static StringResource JointNew_RepairTypeGridColumn = new StringResource
        {
            Id = "JointNew_RepairTypeGridColumn",
            Description = "Название операции"
        };

        public static StringResource JointNew_RepairDateGridColumn = new StringResource
        {
            Id = "JointNew_RepairDateGridColumn",
            Description = "Дата"
        };

        public static StringResource JointNew_CompletedGridColumn = new StringResource
        {
            Id = "JointNew_CompletedGridColumn",
            Description = "Выполнено"
        };

        public static StringResource JointNew_WeldersGridColumn = new StringResource
        {
            Id = "JointNew_WeldersGridColumn",
            Description = "Сварщики"
        };

        public static StringResource JointNew_ControlTypeGridColumn = new StringResource
        {
            Id = "JointNew_ControlTypeGridColumn",
            Description = "Название операции"
        };

        public static StringResource JointNew_ResultGridColumn = new StringResource
        {
            Id = "JointNew_ResultGridColumn",
            Description = "Результат"
        };

        public static StringResource JointNew_ControlDateGridColumn = new StringResource
        {
            Id = "JointNew_ControlDateGridColumn",
            Description = "Дата контроля"
        };

        public static StringResource JointNew_InspectorsGridColumn = new StringResource
        {
            Id = "JointNew_InspectorsGridColumn",
            Description = "Инспекторы"
        };

        public static StringResource JointNew_ValueGridColumn = new StringResource
        {
            Id = "JointNew_ValueGridColumn",
            Description = "Значение"
        };

        public static StringResource Joint_WithdrawQuestionHeader = new StringResource
        {
            Id = "Joint_WithdrawQuestionHeader",
            Description = "Заголовок вопроса о вырезке стыка: Вырезка стыка"
        };

        public static StringResource Joint_WithdrawQuestion = new StringResource
        {
            Id = "Joint_WithdrawQuestion",
            Description = "Текст вопроса о вырезке стыка: Данное действие приведет к разъединению элементов трубопровода. Вы действительно хотите вырезать стык?"
        };

        public static StringResource Joint_DeactivationQuestion = new StringResource
        {
            Id = "Joint_DeactivationQuestion",
            Description = "Вопрос о деактивации стыка: Данное действие приведет к деактивации стыка. Параметры стыка станут невозможны для редактирования. Деактивировать стык?"
        };

        public static StringResource Joint_DeactivationQuestionHeader = new StringResource
        {
            Id = "Joint_DeactivationQuestionHeader",
            Description = "Заголовок вопроса о деактивации стыка: Деактивация стыка"
        };

        public static StringResource Joint_Saved = new StringResource
        {
            Id = "Joint_Saved",
            Description = "Сообщение о сохранении стыка: Стык успешно сохранен в базе. Стык  #"
        };

        public static StringResource Joint_SavedHeader = new StringResource
        {
            Id = "Joint_SavedHeader",
            Description = "Заголовок сообщения о сохранении стыка: Сохранение стыка"
        };

        public static StringResource Joint_Duplicate = new StringResource
        {
            Id = "Joint_Duplicate",
            Description = "Сообщение о дублировании стыка: Уже существует стык с номером:"
        };

        public static StringResource Joint_DuplicateHeader = new StringResource
        {
            Id = "Joint_DuplicateHeader",
            Description = "Заголовок сообщения о дублировании стыка: Дублирование номера стыка"
        };

        public static StringResource Joint_IncorrectDiameter = new StringResource
        {
            Id = "Joint_IncorrectDiameter",
            Description = "Сообщение о диаметрах: Отсутствуют подходящие диаметры для формирования стыка."
        };

        public static StringResource Joint_IncorrectDiameterHeader = new StringResource
        {
            Id = "Joint_IncorrectDiameterHeader",
            Description = "Заголовок сообщения о диаметрах: Не совпадают диаметры стыкуемых элементов"
        };

        #endregion //--- JointNew ---

        #region --- JointSearch ---

        public static StringResource JointSearch_JointNumber = new StringResource
        {
            Id = "JointSearch_JointNumber",
            Description = "Ном&ер стыка"
        };

        public static StringResource JointSearch_ControlStateLayout = new StringResource
        {
            Id = "JointSearch_ControlStateLayout",
            Description = "С&татус"
        };

        public static StringResource JointSearch_WeldingDateLabel = new StringResource
        {
            Id = "JointSearch_WeldingDateLabel",
            Description = "Дата сварки"
        };

        public static StringResource JointSearch_WeldingDateFromLayout = new StringResource
        {
            Id = "JointSearch_WeldingDateFromLayout",
            Description = "с"
        };

        public static StringResource JointSearch_WeldingDateToLayout = new StringResource
        {
            Id = "JointSearch_WeldingDateToLayout",
            Description = "по"
        };

        public static StringResource JointSearch_KMlayout = new StringResource
        {
            Id = "JointSearch_KMlayout",
            Description = "Номер п&икета"
        };

        public static StringResource JointSearch_ActivityLayout = new StringResource
        {
            Id = "JointSearch_ActivityLayout",
            Description = "Состояние стыка"
        };

        public static StringResource JointSearch_SearchLayoutGroup = new StringResource
        {
            Id = "JointSearch_SearchLayoutGroup",
            Description = "Параметры поиска"
        };

        public static StringResource JointSearch_SearchButton = new StringResource
        {
            Id = "JointSearch_SearchButton",
            Description = "&Поиск"
        };

        public static StringResource JointSearch_SearchResultLayoutGroup = new StringResource
        {
            Id = "JointSearch_SearchResultLayoutGroup",
            Description = "Резул&ьтаты поиска"
        };

        public static StringResource JointSearch_JointNumberGridColumn = new StringResource
        {
            Id = "JointSearch_JointNumberGridColumn",
            Description = "Номер стыка"
        };

        public static StringResource JointSearch_JoinStatusGridColumn = new StringResource
        {
            Id = "JointSearch_JoinStatusGridColumn",
            Description = "Статус"
        };

        public static StringResource JointSearch_NumberKPCol = new StringResource
        {
            Id = "JointSearch_NumberKPCol",
            Description = "Номер пикета"
        };

        public static StringResource JointSearch_LoweringDateCol = new StringResource
        {
            Id = "JointSearch_LoweringDateCol",
            Description = "Дата укладки"
        };

        public static StringResource JointSearch_GpsLatCol = new StringResource
        {
            Id = "JointSearch_GpsLatCol",
            Description = "Широта"
        };

        
        public static StringResource JointSearch_GpsLongCol = new StringResource
        {
            Id = "JointSearch_GpsLongCol",
            Description = "Долгота"
        };

                
        public static StringResource JointSearch_GpsHeightCol = new StringResource
        {
            Id = "JointSearch_GpsHeightCol",
            Description = "Высота"
        };

        #endregion //--- JointSearch ---

        #region --- ConstructionReports ---

        public static StringResource ConstructionReports_ReportTypeLayout = new StringResource
        {
            Id = "ConstructionReports_ReportTypeLayout",
            Description = "Тип отчета"
        };
        
        public static StringResource ConstructionReports_TypeLayout = new StringResource
        {
            Id = "ConstructionReports_TypeLayout",
            Description = "Тип изделия"
        };
                
        public static StringResource ConstructionReports_StartJointLayout = new StringResource
        {
            Id = "ConstructionReports_StartJointLayout",
            Description = "Начальный стык"
        };
                        
        public static StringResource ConstructionReports_StartKPComboBoxLayoutControl = new StringResource
        {
            Id = "ConstructionReports_StartKPComboBoxLayoutControl",
            Description = "Начальный пикет"
        };
                              
        public static StringResource ConstructionReports_EndJointLayout = new StringResource
        {
            Id = "ConstructionReports_EndJointLayout",
            Description = "Конечный стык"
        };
                                      
        public static StringResource ConstructionReports_EndKPLayout = new StringResource
        {
            Id = "ConstructionReports_EndKPLayout",
            Description = "Конечный пикет"
        };
                                           
        public static StringResource ConstructionReports_PreviewButton = new StringResource
        {
            Id = "ConstructionReports_PreviewButton",
            Description = "&Предпросмотр"
        };
                                                   
        public static StringResource ConstructionReports_CreateReportButton = new StringResource
        {
            Id = "ConstructionReports_CreateReportButton",
            Description = "Соз&дать отчет"
        };
                                                   
        public static StringResource ConstructionReports_CreateReportaLyoutGroup = new StringResource
        {
            Id = "ConstructionReports_CreateReportaLyoutGroup",
            Description = "Сформировать отчёт"
        };
                                                           
        public static StringResource ConstructionReports_PreviewLayoutGroup = new StringResource
        {
            Id = "ConstructionReports_PreviewLayoutGroup",
            Description = "Предварительный просмотр отчёта"
        };

                                                                   
        public static StringResource ConstructionReport_RadioJoints = new StringResource
        {
            Id = "ConstructionReport_RadioJoints",
            Description = "Стыки"
        };
                                                               
        public static StringResource ConstructionReport_RadioKP = new StringResource
        {
            Id = "ConstructionReport_RadioKP",
            Description = "Пикеты"
        };


        #endregion //--- ConstructionReports ---

        #region --- PipeConstractionReport ---

        public static StringResource PipeConstractionReport_PipeNumberLayout = new StringResource
        {
            Id = "PipeConstractionReport_PipeNumberLayout",
            Description = "Номер трубы"
        };
        
        public static StringResource PipeConstractionReport_PipeTypeCheckedComboLayout = new StringResource
        {
            Id = "PipeConstractionReport_PipeTypeCheckedComboLayout",
            Description = "Типоразмер"
        };
        
        public static StringResource PipeConstractionReport_PipeReportParametersLayoutGroup = new StringResource
        {
            Id = "PipeConstractionReport_PipeReportParametersLayoutGroup",
            Description = "Параметры отчета по трубам"
        };
        
        public static StringResource PipeConstractionReport_PreviewButton = new StringResource
        {
            Id = "PipeConstractionReport_PreviewButton",
            Description = "&Предпросмотр"
        };

        public static StringResource PipeConstractionReport_CreateReportButton = new StringResource
        {
            Id = "PipeConstractionReport_CreateReportButton",
            Description = "Соз&дать отчет"
        };
        
        public static StringResource PipeConstractionReport_DocumentViewerLayoutGroup = new StringResource
        {
            Id = "PipeConstractionReport_DocumentViewerLayoutGroup",
            Description = "Предварительный просмотр отчёта"
        };

        public static StringResource ConstractionReport_ReportTypeTracingReport = new StringResource
        {
            Id = "ConstractionReport_ReportTypeTracingReport",
            Description = "Тип отчета. По трассировке"
        };

        public static StringResource ConstractionReport_ReportTypeUsedProductReport = new StringResource
        {
            Id = "ConstractionReport_ReportTypeUsedProductReport",
            Description = "Тип отчета. По использованным изделиям"
        };

        public static StringResource ConstractionReport_TracingReportInfoLabelText = new StringResource
        {
            Id = "ConstractionReport_TracingReportInfoLabelText",
            Description = "Отчеты на строительстве.Текст информационного поля отчета по использованным изделиям"
        };

        #endregion //--- PipeConstractionReport ---

        #region --- WeldDateReport ---

        public static StringResource WeldDateReport_WeldDateFromLayout = new StringResource {
            Id = "WeldDateReport_WeldDateFromLayout",
            Description = "Дата сварки: С"
        };
        
        public static StringResource WeldDateReport_WeldDateToLayout = new StringResource {
            Id = "WeldDateReport_WeldDateToLayout",
            Description = "Дата сварки: По"
        };
        
        public static StringResource WeldDateReport_PreviewButton = new StringResource {
            Id = "WeldDateReport_PreviewButton",
            Description = "&Предпросмотр"
        };
        
        public static StringResource WeldDateReport_CreateReportButton = new StringResource {
            Id = "WeldDateReport_CreateReportButton",
            Description = "Соз&дать отчет"
        };
                
        public static StringResource WeldDateReport_WeldReportParameterGroup = new StringResource {
            Id = "WeldDateReport_WeldReportParameterGroup",
            Description = "Сформировать отчёт"
        };
        
        public static StringResource WeldDateReport_JointReportViewerGroup = new StringResource {
            Id = "WeldDateReport_JointReportViewerGroup",
            Description = "Предварительный просмотр отчёта"
        };

        #endregion //--- WeldDateReport ---

        #region --- JointCutDialog ---

        public static StringResource JointCutDialog_FirstJoinedPartGroup = new StringResource {
            Id = "JointCutDialog_FirstJoinedPartGroup",
            Description = "Первый элемент"
        };
        
        public static StringResource JointCutDialog_FirstJoinedPartNumberLayout = new StringResource {
            Id = "JointCutDialog_FirstJoinedPartNumberLayout",
            Description = "Номер"
        };
                
        public static StringResource JointCutDialog_FirstJoinedPartLengthLayout = new StringResource {
            Id = "JointCutDialog_FirstJoinedPartLengthLayout",
            Description = "Длина, мм"
        };
             
        public static StringResource JointCutDialog_SecondJoinedPartGroup = new StringResource {
            Id = "JointCutDialog_SecondJoinedPartGroup",
            Description = "Второй элемент"
        };

        public static StringResource JointCutDialog_SecondJoinedPartNumberLayout = new StringResource
        {
            Id = "JointCutDialog_SecondJoinedPartNumberLayout",
            Description = "Номер"
        };
        
        public static StringResource JointCutDialog_SecondJoinedPartLengthLayout = new StringResource {
            Id = "JointCutDialog_SecondJoinedPartLengthLayout",
            Description = "Длина, мм"
        };
        
        public static StringResource JointCutDialog_CutJointButton = new StringResource {
            Id = "JointCutDialog_CutJointButton",
            Description = "Вырезать"
        };
        
        public static StringResource JointCutDialog_CancelButton = new StringResource {
            Id = "JointCutDialog_CancelButton",
            Description = "Отмена"
        };



        #endregion //--- JointCutDialog ---

        #region --- SelectDiameterDialog ---

        public static StringResource SelectDiameterDialog_DiametersIntersectionLayout = new StringResource {
            Id = "SelectDiameterDialog_DiametersIntersectionLayout",
            Description = "Выбор диаметра соединения"
        };
        
        public static StringResource SelectDiameterDialog_SaveChosenDiameter = new StringResource {
            Id = "SelectDiameterDialog_SaveChosenDiameter",
            Description = "Сохранить"
        };

        #endregion //--- SelectDiameterDialog ---

        #region --- MillInspectionXtraForm ---
        public static StringResource MillInspection_FrequencyMeasureMeters = new StringResource { 
            Id = "MillInspection_FrequencyMeasureMeters", 
            Description = "Настройка контрольных опрераций завода. Мера измерения метры"};

        public static StringResource MillInspection_FrequencyMeasureTons = new StringResource { 
            Id = "MillInspection_FrequencyMeasureTons", 
            Description = "Настройка контрольных опрераций завода. Мера измерения тонны"};

        public static StringResource MillInspection_FrequencyMeasurePipes = new StringResource { 
            Id = "MillInspection_FrequencyMeasurePipes", 
            Description = "Настройка контрольных опрераций завода. Мера измерения трубы"};

        public static StringResource MillInspection_SaveButton = new StringResource { 
            Id = "MillInspection_SaveButton", Description = 
            "Настройка контрольных опрераций завода. Надпись кнопки сохранения"};

        public static StringResource MillInspection_CancelButton = new StringResource { 
            Id = "MillInspection_CancelButton", 
            Description = "Настройка контрольных опрераций завода. Надпись кнопки отмены"};

        public static StringResource MillInspection_IsRequiredCheckbox = new StringResource { 
            Id = "MillInspection_IsRequiredCheckbox", 
            Description = "Настройка контрольных опрераций завода. Надпись чекбокса Обязательна"};

        public static StringResource MillInspection_IsActiveCheckbox = new StringResource { 
            Id = "MillInspection_IsActiveCheckbox", 
            Description = "Настройка контрольных опрераций завода. Надпись чекбокса Активна"};

        public static StringResource MillInspection_YesNoExpectedCheckbox = new StringResource { 
            Id = "MillInspection_YesNoExpectedCheckbox", 
            Description = "Настройка контрольных опрераций завода. Надпись чекбокса булевого значения"};

        public static StringResource MillInspection_CodeLabel = new StringResource { 
            Id = "MillInspection_CodeLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись кода"};

        public static StringResource MillInspection_NameLabel = new StringResource { 
            Id = "MillInspection_NameLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись названия"};

        public static StringResource MillInspection_CategoryLabel = new StringResource { 
            Id = "MillInspection_CategoryLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись категории"};

        public static StringResource MillInspection_ResultTypeLabel = new StringResource { 
            Id = "MillInspection_ResultTypeLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись типа результата"};

        public static StringResource MillInspection_ControlTypeLabel = new StringResource { 
            Id = "MillInspection_ControlTypeLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись типа контроля"};

        public static StringResource MillInspection_FromLabel = new StringResource { 
            Id = "MillInspection_FromLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись нижней границы значения"};

        public static StringResource MillInspection_ToLabel = new StringResource { 
            Id = "MillInspection_ToLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись верхней границы значения"};

        public static StringResource MillInspection_FrequencyLabel = new StringResource { 
            Id = "MillInspection_FrequencyLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись частоты"};

        public static StringResource MillInspection_FrequencyMeasureLabel = new StringResource { 
            Id = "MillInspection_FrequencyMeasureLabel", 
            Description = "Настройка контрольных опрераций завода. Надпись единицы измерения частоты"};

        public static StringResource MillInspection_RangeControlValueGroup = new StringResource { 
            Id = "MillInspection_RangeControlValueGroup", 
            Description = "Настройка контрольных опрераций завода. Надпись панели контрольного значения диапазон"};

        public static StringResource MillInspection_BoolControlValueGroup = new StringResource { 
            Id = "MillInspection_BoolControlValueGroup", 
            Description = "Настройка контрольных опрераций завода. Надпись панели булевого контрольного значения"};

        public static StringResource MillInspection_FrequencyGroup = new StringResource { 
            Id = "MillInspection_FrequencyGroup", 
            Description = "Настройка контрольных опрераций завода. Надпись панели частоты"};

        #endregion

        #region --- PartInspectionXtraForm ---
        public static StringResource PartInspection_SearchNumberLabel = 
            new StringResource { 
                Id = "PartInspection_SearchNumberLabel", 
                Description = "Входной контроль элемента. Надпись искомого номера"};

        public static StringResource PartInspection_ElementNumberLabel = new StringResource { 
            Id = "PartInspection_ElementNumberLabel", 
            Description = "Входной контроль элемента. Надпись номера элемента"};

        public static StringResource PartInspection_ElementTypeLabel = new StringResource { 
            Id = "PartInspection_ElementTypeLabel", 
            Description = "Входной контроль элемента. Надпись типа элемента"};

        public static StringResource PartInspection_SearchButton = new StringResource { 
            Id = "PartInspection_SearchButton", 
            Description = "Входной контроль элемента. Надпись кнопки поиска"};

        public static StringResource PartInspection_SaveButton = new StringResource { 
            Id = "PartInspection_SaveButton", 
            Description = "Входной контроль элемента. Надпись кнопки сохранения"};

        public static StringResource PartInspection_SaveAndClearButton = new StringResource { 
            Id = "PartInspection_SaveAndClearButton", 
            Description = "Входной контроль элемента. Надпись кнопки сохранения и очистки"};

        public static StringResource PartInspection_DateColumnHeader = new StringResource { 
            Id = "PartInspection_DateColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки даты"};

        public static StringResource PartInspection_ResultColumnHeader = new StringResource { 
            Id = "PartInspection_ResultColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки результата"};

        public static StringResource PartInspection_InspectorColumnHeader = new StringResource {
            Id = "PartInspection_InspectorColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки инспектора"};

        public static StringResource PartInspection_ReasonColumnHeader = new StringResource { 
            Id = "PartInspection_ReasonColumnHeader", 
            Description = "Входной контроль элемента. Надпись колонки причины"};

        public static StringResource PartInspection_SearchGroup = new StringResource { 
            Id = "PartInspection_SearchGroup", 
            Description = "Входной контроль элемента. Надпись панели поиска"};

        public static StringResource PartInspection_IncomingInspectionGroup = new StringResource { 
            Id = "PartInspection_IncomingInspectionGroup", 
            Description = "Входной контроль элемента. Надпись инспекций"};

        public static StringResource Message_UnknownComponentType = new StringResource
        {
            Id = "Message_UnknownComponentType",
            Description = "Сообщение: Неизвестный тип компонента"
        };

        #endregion

        #region---NewEdit Pipe---

        public static StringResource Mask_Label = new StringResource
        {
            Id = "Mask_Label",
            Description = "Правила задания формата трубы: Правила задания формата : # - цифра, @ - буква, % - цифра или буква, ? - любой печатный символ, все остальные символы принимаются как есть"
        };

        public static StringResource NewEditPipe_PipeNumberLabel = new StringResource
        {
            Id = "NewEditPipe_PipeNumberLabel",
            Description = "Труба. Номер трубы"
        };
        public static StringResource NewEditPipe_PipeSizeLabel = new StringResource
        {
            Id = "NewEditPipe_PipeSizeLabel",
            Description = "Труба. Типоразмер"
        };
        public static StringResource NewEditPipe_HeatsComboLabel = new StringResource
        {
            Id = "NewEditPipe_HeatsComboLabel",
            Description = "Труба. Плавка"
        };
        public static StringResource NewEditPipe_PurchaseOrdersComboLabel = new StringResource
        {
            Id = "NewEditPipe_PurchaseOrdersComboLabel",
            Description = "Труба. Номер наряд-заказа"
        };
        public static StringResource NewEditPipe_PurchaseOrederDateLabel = new StringResource
        {
            Id = "NewEditPipe_PurchaseOrederDateLabel",
            Description = "Труба. Дата наряд-заказа"
        };
        public static StringResource NewEditPipe_PipeCreationLabel = new StringResource
        {
            Id = "NewEditPipe_PipeCreationLabel",
            Description = "Труба. Дата создания трубы"
        };
        public static StringResource NewEditPipe_PipeStatusLabel = new StringResource
        {
            Id = "NewEditPipe_PipeStatusLabel",
            Description = "Труба. Статус трубы"
        };
        public static StringResource NewEditPipe_PlateNumberLabel = new StringResource
        {
            Id = "NewEditPipe_PlateNumberLabel",
            Description = "Труба. Номер листа"
        };
        public static StringResource NewEditPipe_PlateThicknessLabel = new StringResource
        {
            Id = "NewEditPipe_PlateThicknessLabel",
            Description = "Труба. Толщина листа"
        };
        public static StringResource NewEditPipe_PlateManufacturerLabel = new StringResource
        {
            Id = "NewEditPipe_PlateManufacturerLabel",
            Description = "Труба. Производитель листа"
        };
        public static StringResource NewEditPipe_PlateSteelGradeLabel = new StringResource
        {
            Id = "NewEditPipe_PlateSteelGradeLabel",
            Description = "Труба. Марка стали"
        };
        public static StringResource NewEditPipe_PipeLengthLabel = new StringResource
        {
            Id = "NewEditPipe_PipeLengthLabel",
            Description = "Труба. Длина трубы"
        };
        public static StringResource NewEditPipe_PipeWeightLabel = new StringResource
        {
            Id = "NewEditPipe_PipeWeightLabel",
            Description = "Труба. Вес трубы"
        };
        public static StringResource NewEditPipe_TypeSizeLengthLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeLengthLabel",
            Description = "Труба. Длина по типоразмеру"
        };
        public static StringResource NewEditPipe_TypeSizeDiameterLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeDiameterLabel",
            Description = "Труба. Диаметр по типоразмеру"
        };
        public static StringResource NewEditPipe_TypeSizeThicknessLabel = new StringResource
        {
            Id = "NewEditPipe_TypeSizeThicknessLabel",
            Description = "Труба. Толщина по типоразмеру"
        };
        public static StringResource NewEditPipe_RailcarNumber_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarNumber_Label",
            Description = "Труба. Номер вагона"
        };
        public static StringResource NewEditPipe_RailcarCertificate_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarCertificate_Label",
            Description = "Труба. Сертификат вагона"
        };
        public static StringResource NewEditPipe_RailcarShippedDate_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarShippedDate_Label",
            Description = "Труба. Дата отправки вагона"
        };
        public static StringResource NewEditPipe_RailcarDestination_Label = new StringResource
        {
            Id = "NewEditPipe_RailcarDestination_Label",
            Description = "Труба. Получатель"
        };
        public static StringResource NewEditPipe_AttachmentsButton = new StringResource
        {
            Id = "NewEditPipe_AttachmentsButton",
            Description = "Труба. Кнопка добавления файлов"
        };
        public static StringResource NewEditPipe_DeactivatedCheckBox = new StringResource
        {
            Id = "NewEditPipe_DeactivatedCheckBox",
            Description = "Труба. Деактивация"
        };
        public static StringResource NewEditPipe_SaveButton = new StringResource
        {
            Id = "NewEditPipe_SaveButton",
            Description = "Труба. Кнопка сохранить"
        };
        public static StringResource NewEditPipe_SaveAndNewButton = new StringResource
        {
            Id = "NewEditPipe_SaveAndNewButton",
            Description = "Труба. Кнопка сохранить и создать"
        };
        public static StringResource NewEditPipe_InspectionsAddButton = new StringResource
        {
            Id = "NewEditPipe_InspectionsAddButton",
            Description = "Труба. Кнопка добавления контрольных операций"
        };
        public static StringResource NewEditPipe_InspectionsEditsButton = new StringResource
        {
            Id = "NewEditPipe_InspectionsEditsButton",
            Description = "Труба. Кнопка редактирования контрольных операций"
        };
        public static StringResource NewEditPipe_WeldersColumnHeader = new StringResource
        {
            Id = "NewEditPipe_WeldersColumnHeader",
            Description = "Труба. Столбец сварщики"
        };
        public static StringResource NewEditPipe_WeldingDateColumnHeader = new StringResource
        {
            Id = "NewEditPipe_WeldingDateColumnHeader",
            Description = "Труба. Столбец дата сварки"
        };
        public static StringResource NewEditPipe_CoatingDateColumnHeader = new StringResource
        {
            Id = "NewEditPipe_CoatingDateColumnHeader",
            Description = "Труба. Столбец дата покрытия"
        };
        public static StringResource NewEditPipe_CoatingTypeColumnHeader = new StringResource
        {
            Id = "NewEditPipe_CoatingTypeColumnHeader",
            Description = "Труба. Столбец тип покрытия"
        };
        public static StringResource NewEditPipe_InspectionCodeColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionCodeColumnHeader",
            Description = "Труба. Столбец код контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionNameColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionNameColumnHeader",
            Description = "Труба. Столбец название контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionCategoryColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionCategoryColumnHeader",
            Description = "Труба. Столбец группа контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionExpectedResultColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionExpectedResultColumnHeader",
            Description = "Труба. Столбец ожидаемого результата контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionValueColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionValueColumnHeader",
            Description = "Труба. Столбец значения контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionResultColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionResultColumnHeader",
            Description = "Труба. Столбец результата контрольной операции"
        };
        public static StringResource NewEditPipe_InspectionDateColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectionDateColumnHeader",
            Description = "Труба. Столбец даты контрольной операции"
        };
        public static StringResource NewEditPipe_InspectorsCodeColumnHeader = new StringResource
        {
            Id = "NewEditPipe_InspectorsCodeColumnHeader",
            Description = "Труба. Столбец инспекторы"
        };
        public static StringResource NewEditPipe_PlateGroup = new StringResource
        {
            Id = "NewEditPipe_PlateGroup",
            Description = "Труба. Группа лист"
        };
        public static StringResource NewEditPipe_FactSizeGroup = new StringResource
        {
            Id = "NewEditPipe_FactSizeGroup",
            Description = "Труба. Группа фактических параметров"
        };
        public static StringResource NewEditPipe_TypeSizeGroup = new StringResource
        {
            Id = "NewEditPipe_TypeSizeGroup",
            Description = "Труба. Группа параметров типоразмера"
        };
        public static StringResource NewEditPipe_ShippingGroup = new StringResource
        {
            Id = "NewEditPipe_ShippingGroup",
            Description = "Труба. Группа отправка"
        };
        public static StringResource NewEditPipe_CoverGroup = new StringResource
        {
            Id = "NewEditPipe_CoverGroup",
            Description = "Труба. Группа покрытие"
        };
        public static StringResource NewEditPipe_WeldsGroup = new StringResource
        {
            Id = "NewEditPipe_WeldsGroup",
            Description = "Труба. Группа сварка"
        };
        public static StringResource NewEditPipe_PipeTabGroup = new StringResource
        {
            Id = "NewEditPipe_PipeTabGroup",
            Description = "Труба. Вкладка трубы"
        };
        public static StringResource NewEditPipe_InspectionsTabGroup = new StringResource
        {
            Id = "NewEditPipe_InspectionsTabGroup",
            Description = "Труба. Вкладка контрольных операций"
        };
        public static StringResource NewEditPipe_PipeStatusUndefined = new StringResource
        {
            Id = "NewEditPipe_PipeStatusUndefined",
            Description = "Труба. Статус не определен"
        };
        public static StringResource NewEditPipe_PipeStatusProduced = new StringResource
        {
            Id = "NewEditPipe_PipeStatusProduced",
            Description = "Труба. Статус в производстве"
        };
        public static StringResource NewEditPipe_PipeStatusStocked = new StringResource
        {
            Id = "NewEditPipe_PipeStatusStocked",
            Description = "Труба. Статус на складе"
        };
        public static StringResource NewEditPipe_PipeStatusShipped = new StringResource
        {
            Id = "NewEditPipe_PipeStatusShipped",
            Description = "Труба. Статус отгружена"
        };

        public static StringResource MillPipe_CoatInternal = new StringResource
        {
            Id = "MillPipe_CoatInternal",
            Description = "Труба, тип покрытия: Внутреннее"
        };

        public static StringResource MillPipe_CoatExternal = new StringResource
        {
            Id = "MillPipe_CoatExternal",
            Description = "Труба, тип покрытия: Внешнее"
        };

        public static StringResource MillPipe_PipeSizeChangeHeader = new StringResource
        {
            Id = "MillPipe_PipeSizeChangeHeader",
            Description = "Заголовок сообщения - подтверждения об изменении типоразмера трубы"
        };

        public static StringResource MillPipe_ChangeTypesizeConfirmation = new StringResource
        {
            Id = "MillPipe_ChangeTypesizeConfirmation",
            Description = "Вопрос о подтверждении изменения типоразмера: Вы действительно хотите изменить типоразмер трубы? Все введённые результаты контрольных операций будут удалены и необходимо их ввести заново"
        };

        public static StringResource MillPipe_NotAllowedToChangeTypesize = new StringResource
        {
            Id = "MillPipe_NotAllowedToChangeTypesize",
            Description = "Сообщение о невозможности изменить типоразмер: Нельзя изменить типоразмер для трубы, у которой уже есть данные по контрольным операциям. Если типоразмер ошибочен, деактивируйте эту трубу и создайте новую с таким же номером и правильным типоразмером."
        };

        public static StringResource MillPipe_ValueDoesNotMatchMask = new StringResource
        {
            Id = "MillPipe_ValueDoesNotMatchMask",
            Description = "Сообщение об ошибке: Значение не соответствует маске"
        };

        public static StringResource MillPipe_NewHeatQuestion = new StringResource
        {
            Id = "MillPipe_NewHeatQuestion",
            Description = "Вопрос о создании новой плавки: Создать плавку {0}?"
        };

        public static StringResource MillPipe_NewHeadQuestionHeader = new StringResource
        {
            Id = "MillPipe_NewHeadQuestionHeader",
            Description = "Заголовок вопроса о создании новой плавки: Новая плавка"
        };

        public static StringResource MillPipe_NewPurchaseOrderQuestion = new StringResource
        {
            Id = "MillPipe_NewPurchaseOrderQuestion",
            Description = "Вопрос о создании нового наряд-заказа: Создать наряд-заказ {0}?"
        };

        public static StringResource MillPipe_NewPurchaseOrderQuestionHeader = new StringResource
        {
            Id = "MillPipe_NewPurchaseOrderQuestionHeader",
            Description = "Заголовок вопроса о создании нового наряд-заказа: Новый наряд-заказ"
        };

        public static StringResource MillPipe_DeactivatePipeQuestion = new StringResource
        {
            Id = "MillPipe_DeactivatePipeQuestion",
            Description = "Вопрос о деактивации: Данное действие приведет к деактивации трубы. Параметры трубы станут невозможны для редактирования. Деактивировать трубу?"
        };

        public static StringResource MillPipe_DeactivatePipeQuestionHeader = new StringResource
        {
            Id = "MillPipe_DeactivatePipeQuestionHeader",
            Description = "Заголовок вопроса о деактивации: Деактивация трубы"
        };

        public static StringResource MillPipe_DeactivatePipeShippedError = new StringResource
        {
            Id = "MillPipe_DeactivatePipeShippedError",
            Description = "Сообщение: Труба находится в вагоне. Для деактивации необходимо удалить трубу из вагона."
        };

        public static StringResource MillPipe_DeactivatePipeShippedErrorHeader = new StringResource
        {
            Id = "MillPipe_DeactivatePipeShippedErrorHeader",
            Description = "Заголовок сообщения: Деактивация трубы в вагоне невозможна"
        };

        public static StringResource MillPipe_DeactivatePipeInRailcarError = new StringResource
        {
            Id = "MillPipe_DeactivatePipeInRailcarError",
            Description = "Сообщение: Невозможно деактивировать отгруженную трубу."
        };

        public static StringResource MillPipe_DeactivatePipeInRailcarErrorHeader = new StringResource
        {
            Id = "MillPipe_DeactivatePipeInRailcarErrorHeader",
            Description = "Заголовок сообщения: Труба отгружена"
        };

        public static StringResource MillPipe_ExistingNumberError = new StringResource
        {
            Id = "MillPipe_ExistingNumberError",
            Description = "Сообщение об ошибке: Уже существует труба с номером: "
        };

        public static StringResource MillPipe_ExistingNumberErrorHeader = new StringResource
        {
            Id = "MillPipe_ExistingNumberErrorHeader",
            Description = "Заголовок сообщения о дублировании трубы: Дублирование номера трубы"
        };

        public static StringResource MillPipe_PipeSaved = new StringResource
        {
            Id = "MillPipe_PipeSaved",
            Description = "Сообщение об успешном сохранении трубы: Труба успешно сохранена в базе. Труба  # "
        };

        public static StringResource MillPipe_PipeSavedHeader = new StringResource
        {
            Id = "MillPipe_PipeSavedHeader",
            Description = "Заголовок сообщения об успешном сохранении трубы: Сохранение трубы"
        };

        public static StringResource MillPipe_ErrorEditingInspectionOperationPipeInRailcar = new StringResource
        {
            Id = "MillPipe_ErrorEditingInspectionOperationPipeInRailcar",
            Description = "Сообщение: Нельзя добавить неуспешную контрольную операцию для трубы, которая находится в вагоне. Для этого необходимо удалить данную трубу из вагона. "
        };

        public static StringResource MillPipe_ErrorEmptyOrFutureDate = new StringResource
        {
            Id = "MillPipe_ErrorEmptyOrFutureDate",
            Description = "Сообщение об ошибке даты: Дата не может быть пустой или будущей"
        };

        #endregion

        #region---Search pipe---
        public static StringResource SearchPipe_MillStatusProduced = new StringResource
        {
            Id = "SearchPipe_MillStatusProduced",
            Description = "Поиск труб. Статус в производстве"
        };
        public static StringResource SearchPipe_MillStatusStocked = new StringResource
        {
            Id = "SearchPipe_MillStatusStocked",
            Description = "Поиск труб. статус на складе"
        };
        public static StringResource SearchPipe_MillStatusShipped = new StringResource
        {
            Id = "SearchPipe_MillStatusShipped",
            Description = "Поиск труб. статус отгружена"
        };
        public static StringResource SearchPipe_ActivityComboActive = new StringResource
        {
            Id = "SearchPipe_ActivityComboActive",
            Description = "Поиск труб. Активность – активна"
        };
        public static StringResource SearchPipe_ActivityComboNotActive = new StringResource
        {
            Id = "SearchPipe_ActivityComboNotActive",
            Description = "Поиск труб. Активность – деактивирована"
        };
        public static StringResource SearchPipe_ActivityComboAll = new StringResource
        {
            Id = "SearchPipe_ActivityComboAll",
            Description = "Поиск труб. Активность – все"
        };
        public static StringResource SearchPipe_NumberLabel = new StringResource
        {
            Id = "SearchPipe_NumberLabel",
            Description = "Поиск труб. Номер трубы"
        };
        public static StringResource SearchPipe_TypeSizeLabel = new StringResource
        {
            Id = "SearchPipe_TypeSizeLabel",
            Description = "Поиск труб. Типоразмер"
        };
        public static StringResource SearchPipe_StatusLabel = new StringResource
        {
            Id = "SearchPipe_StatusLabel",
            Description = "Поиск труб. Статус трубы"
        };
        public static StringResource SearchPipe_ActivityLabel = new StringResource
        {
            Id = "SearchPipe_ActivityLabel",
            Description = "Поиск труб. Активность трубы"
        };
        public static StringResource SearchPipe_WeldingDateLabel = new StringResource
        {
            Id = "SearchPipe_WeldingDateLabel",
            Description = "Поиск труб. Дата сварки"
        };
        public static StringResource SearchPipe_ExternalCoatingDateLabel = new StringResource
        {
            Id = "SearchPipe_ExternalCoatingDateLabel",
            Description = "Поиск труб. Дата внешнего покрытия"
        };
        public static StringResource SearchPipe_InternalCoatingDateLabel = new StringResource
        {
            Id = "SearchPipe_InternalCoatingDateLabel",
            Description = "Поиск труб. Дата внутреннего покрытия"
        };
        public static StringResource SearchPipe_SearchButton = new StringResource
        {
            Id = "SearchPipe_SearchButton",
            Description = "Поиск труб. Кнопка поиск"
        };
        public static StringResource SearchPipe_PipeNumberColumn = new StringResource
        {
            Id = "SearchPipe_PipeNumberColumn",
            Description = "Поиск труб. Столбец номер трубы"
        };
        public static StringResource SearchPipe_PipeMillColumn = new StringResource
        {
            Id = "SearchPipe_PipeMillColumn",
            Description = "Поиск труб. Столбец завод"
        };
        public static StringResource SearchPipe_PipetypeSizeColumn = new StringResource
        {
            Id = "SearchPipe_PipetypeSizeColumn",
            Description = "Поиск труб. Столбец типоразмер"
        };
        public static StringResource SearchPipe_PipeHeatNumberColumn = new StringResource
        {
            Id = "SearchPipe_PipeHeatNumberColumn",
            Description = "Поиск труб. Столбец плавка"
        };
        public static StringResource SearchPipe_PipeStatusColumn = new StringResource
        {
            Id = "SearchPipe_PipeStatusColumn",
            Description = "Поиск труб. Столбец статус"
        };
        public static StringResource SearchPipe_PipeWeldingDateColumn = new StringResource
        {
            Id = "SearchPipe_PipeWeldingDateColumn",
            Description = "Поиск труб. Столбец дата сварки"
        };
        public static StringResource SearchPipe_ExternalCoatingDateColumn = new StringResource
        {
            Id = "SearchPipe_ExternalCoatingDateColumn",
            Description = "Поиск труб. Столбец дата внешнего покрытия"
        };
        public static StringResource SearchPipe_InternalCoatingColumn = new StringResource
        {
            Id = "SearchPipe_InternalCoatingColumn",
            Description = "Поиск труб. Столбец дата внутреннего покрытия"
        };
        public static StringResource SearchPipe_SearchGroup = new StringResource
        {
            Id = "SearchPipe_SearchGroup",
            Description = "Поиск труб. Группа поиск"
        };
        public static StringResource SearchPipe_ResultGroup = new StringResource
        {
            Id = "SearchPipe_ResultGroup",
            Description = "Поиск труб. Группа результат"
        };
        #endregion

        #region---Release Note NewEdit---
        public static StringResource ReleaseNoteNewEdit_ReleaseNumberLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ReleaseNumberLabel",
            Description = "Разрешение на отгрузку. Номер разрешения"
        };
        public static StringResource ReleaseNoteNewEdit_ReleaseDateLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ReleaseDateLabel",
            Description = "Разрешение на отгрузку. Дата разрешения"
        };
        public static StringResource ReleaseNoteNewEdit_RailcarNumberLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RailcarNumberLabel",
            Description = "Разрешение на отгрузку. Номер вагона"
        };
        public static StringResource ReleaseNoteNewEdit_CertificateLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_CertificateLabel",
            Description = "Разрешение на отгрузку. Сертификат вагона"
        };
        public static StringResource ReleaseNoteNewEdit_DestinationLabel = new StringResource
        {
            Id = "ReleaseNoteNewEdit_DestinationLabel",
            Description = "Разрешение на отгрузку. Получатель"
        };
        public static StringResource ReleaseNoteNewEdit_AddPipeButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_AddPipeButton",
            Description = "Разрешение на отгрузку. Кнопка добавления трубы"
        };
        public static StringResource ReleaseNoteNewEdit_RemovePipeButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_RemovePipeButton",
            Description = "Разрешение на отгрузку. Кнопка удаления трубы"
        };
        public static StringResource ReleaseNoteNewEdit_AttachmentsButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_AttachmentsButton",
            Description = "Разрешение на отгрузку. Кнопка добавления файлов"
        };
        public static StringResource ReleaseNoteNewEdit_ShipButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ShipButton",
            Description = "Разрешение на отгрузку. Кнопка отгрузки"
        };
        public static StringResource ReleaseNoteNewEdit_UnshipButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_UnshipButton",
            Description = "Разрешение на отгрузку. Кнопка отклонения отгрузки"
        };
        public static StringResource ReleaseNoteNewEdit_SaveButton = new StringResource
        {
            Id = "ReleaseNoteNewEdit_SaveButton",
            Description = "Разрешение на отгрузку. Кнопка сохранить"
        };
        public static StringResource ReleaseNoteNewEdit_PipeNumberColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeNumberColumn",
            Description = "Разрешение на отгрузку. Столбец номер трубы"
        };
        public static StringResource ReleaseNoteNewEdit_PipeTypeSizeColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeTypeSizeColumn",
            Description = "Разрешение на отгрузку. Столбец типоразмер"
        };
        public static StringResource ReleaseNoteNewEdit_PipeStatusColumn = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipeStatusColumn",
            Description = "Разрешение на отгрузку. Столбец статус"
        };

        public static StringResource ReleaseNoteNewEdit_ErrorAddingPipeAlreadyInRailcar = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ErrorAddingPipeAlreadyInRailcar",
            Description = "Сообщение о том, что труба уже в вагоне: Данная труба находится в вагоне #"
        };

        public static StringResource ReleaseNoteNewEdit_UnshipFirst = new StringResource
        {
            Id = "ReleaseNoteNewEdit_UnshipFirst",
            Description = "Сообщение: сначала расформируйте вагон/разрешение на отгрузку"
        };

        public static StringResource ReleaseNoteNewEdit_NotShipped = new StringResource
        {
            Id = "ReleaseNoteNewEdit_NotShipped",
            Description = "Сообщение об ошибке попытки отмены отгрузки: Отмена отгрузки не актуальна, вагоны сейчас не отгружены"
        };

        public static StringResource ReleaseNoteNewEdit_Unshipped = new StringResource
        {
            Id = "ReleaseNoteNewEdit_Unshipped",
            Description = "Сообщение об успешной отмене отгрузки: Отгрузка отменена. Дата отгрузки аннулирована. Трубы перемещены на склад."
        };

        public static StringResource ReleaseNoteNewEdit_Shipped = new StringResource
        {
            Id = "ReleaseNoteNewEdit_Shipped",
            Description = "Сообщение об успешной отгрузке: Отгрузка произошла успешно."
        };

        public static StringResource ReleaseNoteNewEdit_PipesAbsent = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PipesAbsent",
            Description = "Сообщение об ошибке отгрузки: Отправка без труб невозможна."
        };

        public static StringResource ReleaseNoteNewEdit_DifferentTypeSizeInRailcar = new StringResource
        {
            Id = "ReleaseNoteNewEdit_DifferentTypeSizeInRailcar",
            Description = "Сообщение об ошибке отгрузки: Все трубы в в вагоне должны быть одного типоразмера."
        };

        public static StringResource ReleaseNoteNewEdit_MissingReleaseNoteNumber = new StringResource
        {
            Id = "ReleaseNoteNewEdit_MissingReleaseNoteNumber",
            Description = "Сообщение об ошибке: Введите номер разрешения на отгрузку."
        };

        public static StringResource ReleaseNoteNewEdit_SaveSuccess = new StringResource
        {
            Id = "ReleaseNoteNewEdit_SaveSuccess",
            Description = "Сообщение: Данные разрешения на отгрузку сохранены"
        };

        public static StringResource ReleaseNoteNewEdit_SaveSuccessHeader = new StringResource
        {
            Id = "ReleaseNoteNewEdit_SaveSuccessHeader",
            Description = "Заголовок сообщения об успешном сохранении: Сохранение успешно"
        };

        public static StringResource ReleaseNoteNewEdit_ShippedStatus = new StringResource
        {
            Id = "ReleaseNoteNewEdit_ShippedStatus",
            Description = "Статус разрешения на отгрузку: отгружено"
        };

        public static StringResource ReleaseNoteNewEdit_PendingStatus = new StringResource
        {
            Id = "ReleaseNoteNewEdit_PendingStatus",
            Description = "Статус разрешения на отгрузку: сформировано"
        };

        #endregion //--- Railcar NewEdit ---


        #region---Railcar Search---
        public static StringResource ReleaseSearch_NumberLabel = new StringResource
        {
            Id = "ReleaseSearch_NumberLabel",
            Description = "Поиск разрешений на отгрузку. Номер разрешения"
        };
        public static StringResource ReleaseSearch_DateLabel = new StringResource
        {
            Id = "ReleaseSearch_DateLabel",
            Description = "Поиск разрешений на отгрузку. Дата"
        };
        public static StringResource ReleaseSearch_DestinationLabel = new StringResource
        {
            Id = "ReleaseSearch_DestinationLabel",
            Description = "Поиск разрешений на отгрузку. Получатель"
        };
        public static StringResource ReleaseSearch_RailcarLabel = new StringResource
        {
            Id = "ReleaseSearch_RailcarLabel",
            Description = "Поиск разрешений на отгрузку. Вагон"
        };
        public static StringResource ReleaseSearch_CertificateLabel = new StringResource
        {
            Id = "ReleaseSearch_CertificateLabel",
            Description = "Поиск разрешений на отгрузку. Сертификат вагона"
        };
        public static StringResource NewEditPipe_SearchButton = new StringResource
        {
            Id = "NewEditPipe_SearchButton",
            Description = "Поиск разрешений на отгрузку. Кнопка поиск"
        };
        public static StringResource ReleaseSearch_ReleaseNumberColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_ReleaseNumberColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец номер разрешения"
        };
        public static StringResource ReleaseSearch_ReleaseDateColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_ReleaseDateColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец дата разрешения"
        };
        public static StringResource ReleaseSearch_RailcarNumberColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_RailcarNumberColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец номер вагона"
        };
        public static StringResource ReleaseSearch_DestinationColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_DestinationColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец получатель"
        };
        public static StringResource ReleaseSearch_CertificateColumnHeader = new StringResource
        {
            Id = "ReleaseSearch_CertificateColumnHeader",
            Description = "Поиск разрешений на отгрузку. Столбец сертификат"
        };
        public static StringResource ReleaseSearch_SearchGroup = new StringResource
        {
            Id = "ReleaseSearch_SearchGroup",
            Description = "Поиск разрешений на отгрузку. Группа поиск"
        };
        public static StringResource ReleaseSearch_ResultGroup = new StringResource
        {
            Id = "ReleaseSearch_ResultGroup",
            Description = "Поиск разрешений на отгрузку. Группа результат"
        };
        #endregion //--- Railcar Search ---

        #region---Login---
        public static StringResource Login_LoginLabel = new StringResource
        {
            Id = "Login_LoginLabel",
            Description = "Логин. Логин"
        };
        public static StringResource Login_PasswordLabel = new StringResource
        {
            Id = "Login_PasswordLabel",
            Description = "Логин. Пароль"
        };
        public static StringResource Login_LoginButton = new StringResource
        {
            Id = "Login_LoginButton",
            Description = "Логин. Кнопка логин"
        };
        public static StringResource Login_ExitButton = new StringResource
        {
            Id = "Login_ExitButton",
            Description = "Логин. Кнопка выход"
        };
        #endregion //--- Login ---

        #region First Setup
        public static StringResource FirstSetup_ProjectTitleLabel = new StringResource
        {
            Id = "FirstSetup_ProjectTitleLabel",
            Description = "Начальные установки. Название проекта"
        };
        public static StringResource FirstSetup_FileSizeLabel = new StringResource
        {
            Id = "FirstSetup_FileSizeLabel",
            Description = "Начальные установки. Размер файла"
        };
        public static StringResource FirstSetup_TypeLabel = new StringResource
        {
            Id = "FirstSetup_TypeLabel",
            Description = "Начальные установки. Тип станции"
        };
        public static StringResource FirstSetup_MillLabel = new StringResource
        {
            Id = "FirstSetup_MillLabel",
            Description = "Начальные установки. Название завода"
        };
        public static StringResource FirstSetup_LoginLabel = new StringResource
        {
            Id = "FirstSetup_LoginLabel",
            Description = "Начальные установки. Логин"
        };
        public static StringResource FirstSetup_PasswordLabel = new StringResource
        {
            Id = "FirstSetup_PasswordLabel",
            Description = "Начальные установки. Пароль"
        };
        public static StringResource FirstSetup_ReEnterPasswordLabel = new StringResource
        {
            Id = "FirstSetup_ReEnterPasswordLabel",
            Description = "Начальные установки. Повторный пароль"
        };
        public static StringResource FirstSetup_LastNameLabel = new StringResource
        {
            Id = "FirstSetup_LastNameLabel",
            Description = "Начальные установки. Фамилия"
        };
        public static StringResource FirstSetup_FirstNameLabel = new StringResource
        {
            Id = "FirstSetup_FirstNameLabel",
            Description = "Начальные установки. имя"
        };
        public static StringResource FirstSetup_MiddleNameLabel = new StringResource
        {
            Id = "FirstSetup_MiddleNameLabel",
            Description = "Начальные установки. Отчество"
        };
        public static StringResource FirstSetup_SaveButton = new StringResource
        {
            Id = "FirstSetup_SaveButton",
            Description = "Начальные установки. Кнопка сохранить"
        };
        public static StringResource FirstSetup_CancelButton = new StringResource
        {
            Id = "FirstSetup_CancelButton",
            Description = "Начальные установки. Кнопка отмена"
        };



        #endregion

        #region Heat
        public static StringResource Heat_NumberLabel = new StringResource
        {
            Id = "Heat_NumberLabel",
            Description = "Плавка. Номер плавки"
        };
        public static StringResource Heat_SteelLabel = new StringResource
        {
            Id = "Heat_SteelLabel",
            Description = "Плавка. Марка стали"
        };
        public static StringResource Heat_PlateManufacturerLabel = new StringResource
        {
            Id = "Heat_PlateManufacturerLabel",
            Description = "Плавка. Производитель листа"
        };
        public static StringResource Heat_SaveButton = new StringResource
        {
            Id = "Heat_SaveButton",
            Description = "Плавка. Кнопка сохранить"
        };
        public static StringResource Heat_CancelButton = new StringResource
        {
            Id = "Heat_CancelButton",
            Description = "Плавка. Кнопка отмена"
        };
        #endregion

        #region Inspection
        public static StringResource InspectionAddEdit_CodeLabel = new StringResource
        {
            Id = "InspectionAddEdit_CodeLabel",
            Description = "Контрольная операция. Код"
        };
        public static StringResource InspectionAddEdit_CategoryLabel = new StringResource
        {
            Id = "InspectionAddEdit_CategoryLabel",
            Description = "Контрольная операция. Категория"
        };
        public static StringResource InspectionAddEdit_NameLabel = new StringResource
        {
            Id = "InspectionAddEdit_NameLabel",
            Description = "Контрольная операция. Название"
        };
        public static StringResource InspectionAddEdit_ExpectedResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_ExpectedResultLabel",
            Description = "Контрольная операция. Ожидаемый результат"
        };
        public static StringResource InspectionAddEdit_FactStringResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_FactStringResultLabel",
            Description = "Контрольная операция. Фактический результат строка"
        };
        public static StringResource InspectionAddEdit_FactBoolResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_FactBoolResultLabel",
            Description = "Контрольная операция. Фактический результат логический"
        };
        public static StringResource InspectionAddEdit_FactLimitResultLabel = new StringResource
        {
            Id = "InspectionAddEdit_FactLimitResultLabel",
            Description = "Контрольная операция. Фактический результат диапазон"
        };
        public static StringResource InspectionAddEdit_DateLabel = new StringResource
        {
            Id = "InspectionAddEdit_DateLabel",
            Description = "Контрольная операция. Дата"
        };
        public static StringResource InspectionAddEdit_StatusLabel = new StringResource
        {
            Id = "InspectionAddEdit_StatusLabel",
            Description = "Контрольная операция. Статус"
        };
        public static StringResource InspectionAddEdit_InspectorsLabel = new StringResource
        {
            Id = "InspectionAddEdit_InspectorsLabel",
            Description = "Контрольная операция. Инспектора"
        };
        public static StringResource InspectionAddEdit_OperationGroup = new StringResource
        {
            Id = "InspectionAddEdit_OperationGroup",
            Description = "Контрольная операция. Группа контрольная операция"
        };
        public static StringResource InspectionAddEdit_ResultGroup = new StringResource
        {
            Id = "InspectionAddEdit_ResultGroup",
            Description = "Контрольная операция. Группа результат"
        };
        public static StringResource InspectionAddEdit_FactStringGroup = new StringResource
        {
            Id = "InspectionAddEdit_FactStringGroup",
            Description = "Контрольная операция. Группа фактический строковый"
        };
        public static StringResource InspectionAddEdit_FactBoolGroup = new StringResource
        {
            Id = "InspectionAddEdit_FactBoolGroup",
            Description = "Контрольная операция. Группа фактический логический"
        };
        public static StringResource InspectionAddEdit_FactLimitGroup = new StringResource
        {
            Id = "InspectionAddEdit_FactLimitGroup",
            Description = "Контрольная операция. Группа фактический диапазон"
        };
        public static StringResource InspectionAddEdit_SaveButton = new StringResource
        {
            Id = "InspectionAddEdit_SaveButton",
            Description = "Контрольная операция. Кнопка сохранить"
        };
        public static StringResource InspectionAddEdit_CancelButton = new StringResource
        {
            Id = "InspectionAddEdit_CancelButton",
            Description = "Контрольная операция. Кнопка отмена"
        };
        #endregion

        #region --- Notification ---

        public static StringResource Notification_DublicatePipeNumber_Critical = new StringResource
        {
            Id = "Notification_DublicatePipeNumber_Critical",
            Description = "Сообщение о дублировании номеров труб: Дубликат номера труб"
        };

        public static StringResource Notification_ExpiredCertificate_Critical = new StringResource
        {
            Id = "Notification_ExpiredCertificate_Critical",
            Description = "Сообщение об окончании срока: Сертификат просрочен"
        };

        public static StringResource Notification_ExpiredCertificate_Warning = new StringResource
        {
            Id = "Notification_ExpiredCertificate_Warning",
            Description = "Сообщение о приближении окончания срока: Заканчивается срок сертификата"
        };

        public static StringResource Notification_WelderCertificateExpired_Critical = new StringResource
        {
            Id = "Notification_WelderCertificateExpired_Critical",
            Description = "Сообщение об окончании срока: Сертификат просрочен"
        };

        #endregion //--- Notification ---
    }
} 
