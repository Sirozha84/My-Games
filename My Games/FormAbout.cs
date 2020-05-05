﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            labelVersion.Text = "Версия: " + Program.Version;
            richTextBoxHostory.Text =
                "Версия 2.2 (05.05.2020)\n\n" +
                "• Возможность удалить обложку(через контекстное меню)\n" +
                "• Исправлена ошибка не дающая изменить обложку\n" +
                "• Исправлена неактивная надпись в рамке с обложкой когда нет изображения\n" +
                "• Исправлено неправильное выделение столбиков в статистике\n" +
                "• Исправлены вылеты при вводе неправильных значений\n" +
                "• Исправлен вылет при попытке посмотреть статистику без данных\n" +
                "• Исправлено обновление вкладки \"Прочее\" при изменении данных\n\n" +
                "Версия 2.1 (29.03.2020)\n\n" +
                "• Новый график в статистике \"размер коллекции\"\n" +
                "• Улучшение рисовки графиков (исправоено скачкообразное масштабирование)\n" +
                "• Новая иконка\n\n" +
                "Версия 2.0 (27.02.2020)\n\n" +
                "• Фильтрация списка игр по разным параметрам\n" +
                "• Фильтрация платформ в выпадающих списках при добавлении DLC или события\n" +
                "• Выделение указанной платформы на диаграмме\n" +
                "• Отображение количества элементов на вкладках формы \"Игры\"\n" +
                "• Более информативная панель информации\n" +
                "• Разделение разрядов чисел в статистике и таблицах\n" +
                "• Отключение раскраски в списке игр\n" +
                "• Переработаны меню и панель инструментов, новые иконки\n" +
                "• Больше информации в строке статуса\n" +
                "• Больше информации на вкладке \"Прочее\"\n" +
                "• Исправлена ошибка неработающих кнопок при работе с DLC\n" +
                "• Поправлен порядок перехода между полнями в форме \"Игра\"\n" +
                "• Исправлена продублированная горячая клавиша F7\n" +
                "• Исправлена ошибка при удалении заметок\n" +
                "• Прочие небольшие исправления и оптимизация\n\n" +
                "Версия 1.3 (06.12.2019)\n\n" +
                "• Новый дизайн формы \"Игра\", информация разделена вкладками\n" +
                "• Возможность прикреплять обложку игры\n" +
                "• Заметки\n\n" +
                "Версия 1.2 (21.10.2019)\n\n" +
                "• Отчёт \"История прохождений\"\n" +
                "• Исправлена ошибка открытия формы игры, форма не открывалась если не было комментария\n" +
                "• Исправлена фильтрация носителей (не везде и не всегда срабатывала)\n" +
                "• Исправлена ошибка перехода на сайт (не всегда переходил)\n" +
                "• Окно \"О программе\" с историей версий\n\n" +
                "Версия 1.1 (19.10.2019)\n\n" +
                "• Отчёт \"История покупок\"\n" +
                "• В платформах можно указать индивидуальный цвет и привязать к ней список носителей, это упрощает выбор носителя при добавлении игры\n" +
                "• Комментарии к версиям и дополнительным материалам\n" +
                "• Унификация форм для всех список в игре\n" +
                "• Небольшие улучшения формы \"Игра\", добавлены разрывы строк в комментариях\n" +
                "• Новое поле \"Сайт\" для хранения ссылки на страницу игры, переход возможен прямо из списка игр\n\n" +
                "Версия 1.0 (12.05.2019)\n\n" +
                "• Статистика по коллекции по пунктам \"Игр куплено\", \"Денег потрачено\" и \"Часов наиграно\", с возможностью выбора масштаба\n" +
                "• Скрываемая информационная панель\n" +
                "• Новые поля в данных: дата создания и дата изменения документа\n" +
                "• Исправлена ошибка даты при быстром создании задним числом\n" +
                "• Исправлена ошибка суммы при быстром создании\n" +
                "• Стрелки направления сортировки в столбцах\n" +
                "• Небольшие общие доработки и изменения в дизайне\n\n" +
                "Версия 0.9 (28.10.2018)\n\n" +
                "• Ведение базы игр со списком покупок, дополнительных материалов и истории прохождения\n" +
                "• Быстрое добавление игры с основными полями";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }
    }
}
