using lr_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_3
{
    public partial class Form1 : Form
    {
        private List<MenuGroup> _menuGroups = new List<MenuGroup>();
        private List<OrderItem> _selectedItems = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();
            InitMenuData();
            LoadMenuGroups();
        }

        private void InitMenuData()
        {
            _menuGroups = new List<MenuGroup>
        {
            new MenuGroup
            {
                GroupName = "Супы",
                Dishes = new List<Dish>
                {
                    new Dish { Name = "Борщ" },
                    new Dish { Name = "Солянка" },
                    new Dish { Name = "Крем-суп грибной" }
                }
            },
            new MenuGroup
            {
                GroupName = "Горячее",
                Dishes = new List<Dish>
                {
                    new Dish { Name = "Стейк" },
                    new Dish { Name = "Котлета по-киевски" },
                    new Dish { Name = "Паста Карбонара" }
                }
            },
            new MenuGroup
            {
                GroupName = "Десерты",
                Dishes = new List<Dish>
                {
                    new Dish { Name = "Тирамису" },
                    new Dish { Name = "Чизкейк" },
                    new Dish { Name = "Мороженое" }
                }
            }
        };
        }


        private void LoadMenuGroups()
        {
            lstMenuGroups.Items.Clear();
            foreach (var group in _menuGroups)
            {
                lstMenuGroups.Items.Add(group.GroupName);
            }
        }

        private void lstMenuGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMenuGroups.SelectedIndex == -1) return;

            string selectedGroup = lstMenuGroups.SelectedItem.ToString();
            var group = _menuGroups.FirstOrDefault(g => g.GroupName == selectedGroup);
            if (group == null) return;

            grpDishes.Controls.Clear();
            int y = 20;

            foreach (var dish in group.Dishes)
            {
                var existingItem = _selectedItems
                    .FirstOrDefault(o => o.GroupName == selectedGroup && o.DishName == dish.Name);

                var chk = new CheckBox
                {
                    Text = dish.Name,
                    Location = new System.Drawing.Point(10, y),
                    AutoSize = true,
                    Checked = existingItem != null
                };
                grpDishes.Controls.Add(chk);

                var num = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = 100,
                    Value = existingItem?.Quantity ?? 1,
                    Location = new System.Drawing.Point(200, y - 2),
                    Enabled = existingItem != null,
                    Width = 50
                };
                grpDishes.Controls.Add(num);

                chk.CheckedChanged += (s, ev) =>
                {
                    num.Enabled = chk.Checked;
                    SaveCurrentSelections();
                };

                num.ValueChanged += (s, ev) =>
                {
                    SaveCurrentSelections();
                };

                y += 30;
            }
        }
        private void SaveCurrentSelections()
        {
            if (lstMenuGroups.SelectedIndex == -1) return;

            string selectedGroup = lstMenuGroups.SelectedItem.ToString();

            // Удаляем старые записи для этой группы
            _selectedItems.RemoveAll(o => o.GroupName == selectedGroup);

            // Добавляем текущие выбранные
            for (int i = 0; i < grpDishes.Controls.Count; i += 2)
            {
                var chk = grpDishes.Controls[i] as CheckBox;
                var num = grpDishes.Controls[i + 1] as NumericUpDown;

                if (chk != null && chk.Checked && num != null)
                {
                    _selectedItems.Add(new OrderItem
                    {
                        GroupName = selectedGroup,
                        DishName = chk.Text,
                        Quantity = (int)num.Value
                    });
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            SaveCurrentSelections();

            rtbOrderSummary.Clear();

            if (_selectedItems.Any())
            {
                var grouped = _selectedItems.GroupBy(o => o.GroupName);
                foreach (var g in grouped)
                {
                    rtbOrderSummary.AppendText($"{g.Key}: {g.Count()} позиций\n");
                    foreach (var item in g)
                    {
                        rtbOrderSummary.AppendText($"  - {item.DishName}: {item.Quantity} шт.\n");
                    }
                }
            }
            else
            {
                rtbOrderSummary.Text = "Вы ничего не выбрали.";
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            _selectedItems.Clear(); 

            lstMenuGroups.ClearSelected();

            grpDishes.Controls.Clear();

            rtbOrderSummary.Clear();

        }
    }
}
