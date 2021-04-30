﻿namespace Zenix.WinUI.myUserControls.UserControl.Base
{
    partial class BaseTablo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.insUpdNavigator = new Zenix.WinUI.myUserControls.Navigator.InsUpdNavigator();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnHareketEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnTümünüSeç = new DevExpress.XtraBars.BarButtonItem();
            this.btnTümSeçimleriKaldır = new DevExpress.XtraBars.BarButtonItem();
            this.btnTümHareketSil = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 279);
            this.insUpdNavigator.Name = "insUpdNavigator";
            this.insUpdNavigator.Size = new System.Drawing.Size(542, 24);
            this.insUpdNavigator.TabIndex = 0;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTümünüSeç),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTümSeçimleriKaldır),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTümHareketSil)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // btnHareketEkle
            // 
            this.btnHareketEkle.Caption = "Hareket Ekle";
            this.btnHareketEkle.Id = 0;
            this.btnHareketEkle.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.addfile_32x32;
            this.btnHareketEkle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert));
            this.btnHareketEkle.Name = "btnHareketEkle";
            // 
            // btnHareketSil
            // 
            this.btnHareketSil.Caption = "Hareket Sil";
            this.btnHareketSil.Id = 1;
            this.btnHareketSil.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.deletelist_16x16;
            this.btnHareketSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.btnHareketSil.Name = "btnHareketSil";
            // 
            // btnTümünüSeç
            // 
            this.btnTümünüSeç.Caption = "Tümünü Seç";
            this.btnTümünüSeç.Id = 2;
            this.btnTümünüSeç.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.task_16x16;
            this.btnTümünüSeç.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.task_32x32;
            this.btnTümünüSeç.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnTümünüSeç.Name = "btnTümünüSeç";
            this.btnTümünüSeç.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnTümSeçimleriKaldır
            // 
            this.btnTümSeçimleriKaldır.Caption = "Tüm Seçimleri Kaldır";
            this.btnTümSeçimleriKaldır.Id = 3;
            this.btnTümSeçimleriKaldır.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.highlightactiveelements_16x16;
            this.btnTümSeçimleriKaldır.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.highlightactiveelements_32x32;
            this.btnTümSeçimleriKaldır.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K));
            this.btnTümSeçimleriKaldır.Name = "btnTümSeçimleriKaldır";
            this.btnTümSeçimleriKaldır.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnTümHareketSil
            // 
            this.btnTümHareketSil.Caption = "Tüm Hareketleri Sil";
            this.btnTümHareketSil.Id = 5;
            this.btnTümHareketSil.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.deletelist16;
            this.btnTümHareketSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.Delete));
            this.btnTümHareketSil.Name = "btnTümHareketSil";
            this.btnTümHareketSil.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHareketEkle,
            this.btnHareketSil,
            this.btnTümünüSeç,
            this.btnTümSeçimleriKaldır,
            this.btnTümHareketSil});
            this.barManager.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(542, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 303);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(542, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 303);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(542, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 303);
            // 
            // BaseTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insUpdNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseTablo";
            this.Size = new System.Drawing.Size(542, 303);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Navigator.InsUpdNavigator insUpdNavigator;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        protected DevExpress.XtraBars.BarButtonItem btnHareketEkle;
        private DevExpress.XtraBars.BarButtonItem btnHareketSil;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarButtonItem btnTümünüSeç;
        protected DevExpress.XtraBars.BarButtonItem btnTümSeçimleriKaldır;
        protected DevExpress.XtraBars.BarButtonItem btnTümHareketSil;
    }
}
