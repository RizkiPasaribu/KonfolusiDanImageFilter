namespace Konfolusi_Dan_Image_Filtering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Browse_button = new System.Windows.Forms.Button();
            this.OriginalPicture = new System.Windows.Forms.PictureBox();
            this.GrayscalePicture = new System.Windows.Forms.PictureBox();
            this.button_Grayscle = new System.Windows.Forms.Button();
            this.FilterPicture = new System.Windows.Forms.PictureBox();
            this.button_Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayscalePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse_button
            // 
            resources.ApplyResources(this.Browse_button, "Browse_button");
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // OriginalPicture
            // 
            this.OriginalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.OriginalPicture, "OriginalPicture");
            this.OriginalPicture.Name = "OriginalPicture";
            this.OriginalPicture.TabStop = false;
            // 
            // GrayscalePicture
            // 
            this.GrayscalePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.GrayscalePicture, "GrayscalePicture");
            this.GrayscalePicture.Name = "GrayscalePicture";
            this.GrayscalePicture.TabStop = false;
            // 
            // button_Grayscle
            // 
            resources.ApplyResources(this.button_Grayscle, "button_Grayscle");
            this.button_Grayscle.Name = "button_Grayscle";
            this.button_Grayscle.UseVisualStyleBackColor = true;
            this.button_Grayscle.Click += new System.EventHandler(this.Convert_Grayscle_button_Click);
            // 
            // FilterPicture
            // 
            this.FilterPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.FilterPicture, "FilterPicture");
            this.FilterPicture.Name = "FilterPicture";
            this.FilterPicture.TabStop = false;
            // 
            // button_Filter
            // 
            resources.ApplyResources(this.button_Filter, "button_Filter");
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.Filter_Image_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.FilterPicture);
            this.Controls.Add(this.button_Grayscle);
            this.Controls.Add(this.GrayscalePicture);
            this.Controls.Add(this.OriginalPicture);
            this.Controls.Add(this.Browse_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayscalePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Browse_button;
        private PictureBox OriginalPicture;
        private PictureBox GrayscalePicture;
        private Button button_Grayscle;
        private PictureBox FilterPicture;
        private Button button_Filter;
    }
}