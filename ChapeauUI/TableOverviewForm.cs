﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogica;

namespace ChapeauUI
{
    public partial class TableOverviewForm : Form
    {
        private Employee employee; // toevoegen in de constructor later. om hiermee te bepalen wie de order opneemt. 
        TableService tableService = new TableService();
        private List<Table> tables;
        private KitchenOrderOverview KitchenOrderOverview;
        private List<OrderGerecht> orderGerecht;
        public TableOverviewForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.KitchenOrderOverview = new KitchenOrderOverview();
        }

        private void buttonUitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void TableClick(object sender, EventArgs e) 
        {
            //parse een sender naar een Button, parse de Tag van die Button naar een Table en geef de TableID van die Table aan de Table table
            Table table = ((Table)((Button)sender).Tag);
            
            //maak een nieuwe TableForm en geef het bijbehorende table mee
            TableForm tableForm = new TableForm(table, this, this.employee);
            tableForm.ShowDialog(); 
        }

        public void AssignTables()
        {
            //pak alle Tables die in database staan
            TableService tableService = new TableService();
            tables = tableService.GetAllTables();

            foreach (Control control in this.Controls)
            {
                //als een Control een Button is en niet de uitlog-button is, voeg dan aan die button de TableClick event toe en assign een tag
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    AssignTag(control);
                }
            }
            SetColor();
        }

        private void AssignEvent() 
        {
            //pak alle Tables die in database staan
            TableService tableService = new TableService();
            tables = tableService.GetAllTables();

            foreach (Control control in this.Controls)
            {
                //als een Control een Button is en niet de uitlog-button is, voeg dan aan die button de TableClick event toe en assign een tag
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    control.Click += TableClick;
                }
            }
            SetColor();
        }

        private void AssignTag(Control control)
        {
            foreach (Table table in tables)
            {
                //als de TableID van een table uit de database overeenkomt met de text van de button voeg dan die Table aan de tag van die button toe
                if (table.TableID == int.Parse(control.Text))
                {
                    control.Tag = table;
                    break;
                }
            }
        }

        private void TableOverviewForm_Load(object sender, EventArgs e)
        {
            // de Load is een soort van constructor. Word aangemaakt op het dat deze form geopend / gelaad wordt. 
            AssignTables();
            AssignEvent();
            // kleur veranderen afhankelijk van IsOccupied
            SetColor();
            this.timerRefreshOverview.Start();
        }

        public void SetColor()
        {
            foreach (Control control in this.Controls)
            {
                Table table = null;
                //als een Control een Button is en niet de uitlog-button is, voeg dan aan die button de TableClick event toe en assign een tag
                if (control.GetType() == typeof(Button) && control != buttonUitloggen)
                {
                    table = (Table)control.Tag;
                    ChangeColor(control, table);
                }
            }
        }

        private void ChangeColor(Control control, Table table) 
        {
            if (!table.IsOccupied)
            {
                control.BackColor = Color.LightGreen;
            }
            else
            {
                control.BackColor = Color.Red;
            }
        }

        private void timerRefreshOverview_Tick(object sender, EventArgs e)
        {
            AssignTables();
/*            if (this.KitchenOrderOverview.ListCompleted(orderGerecht))
            {
                order ophalen uit DB van foreach table table in tables.
                per order, status bekijken. 
                if status == 1, dan gereed. 
                
            }*/
        }

    }
}
