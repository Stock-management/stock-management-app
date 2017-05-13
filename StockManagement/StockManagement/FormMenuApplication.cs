﻿using App.Gwin;
using App.Gwin.Application.Presentation.MainForm;
using App.Gwin.Entities.Secrurity.Authentication;
using StockManagement.BAL;
using StockManagement.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GenericWinForm.Demo
{
    public partial class FormMenuApplication : FormApplication
    {
        public FormMenuApplication()
        {
           // GwinApp.Loading_Status("Creating Application Menu...");
            InitializeComponent();
         
        }

        private void FormMenuApplication_Load(object sender, EventArgs e)
        {
            User user = null;
            // user = User.CreateGuestUser(new ModelContext());
          //  ModelContext db = new ModelContext();
            //user = db.Users.Where(u => u.Reference == "Root").SingleOrDefault();
         //   user = User.CreateAdminUser(new ModelContext());

            user = User.CreateRootUser(new ModelContext());
            // Start Gwin Application with Authentification
           GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), this, user);
        }


        



        ///// <summary>
        ///// Reload the form after language change
        ///// </summary>
        //public override void Reload()
        //{
        //    base.Reload();
        //    InitializeComponent();
        }


    }
