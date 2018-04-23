using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWizard;
using DevExpress.XtraEditors;
using System.Windows.Forms.Design;
using DevExpress.XtraNavBar;

namespace WindowsApplication2
{
    public class MyWizard : WizardControl

    {

        private NavBarControl _NavBar;
        public NavBarControl NavBar
        {
            get { return _NavBar; }
            set { _NavBar = value;
            if (value != null) value.Parent = NavParentControl;
            value.Dock = DockStyle.Fill;
        }
        }

        const  int defaultNavBarWidth = 150;
        protected PanelControl _NavParentControl; 

        public PanelControl NavParentControl
        {
            get { return _NavParentControl; }
        
        }


        public MyWizard()
        {
            CreateNavParentControl();
        }

        protected override WizardViewInfo CreateViewInfo()
        {
            return new MyWizardViewInfo(this); ;
        }
        void CreateNavParentControl()
        {
            _NavParentControl = new PanelControl();
            _NavParentControl.Parent = this;
            _NavParentControl.Width = defaultNavBarWidth;
            _NavParentControl.BackColor = Color.PaleTurquoise ;
            _NavParentControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }


    }
    [Designer(typeof(ParentControlDesigner))]



    public class MyWizardViewInfo : WizardViewInfo
    {
        public MyWizardViewInfo(WizardControl control)
            : base(control)
        {
            
        }

        protected override void UpdatePagesBounds()
        {
            base.UpdatePagesBounds();
            Rectangle rect = Model.GetContentBounds();
            ((MyWizard)WizardControl).NavParentControl.SetBounds(0, rect.Y, ((MyWizard)WizardControl).NavParentControl.Width, rect.Height);
        }

        protected override WizardModelBase CreateWizardModelCore(WizardStyle style)
        {
            if (style == WizardStyle.WizardAero) return new MyWizardAeroModel(this);
            return base.CreateWizardModelCore(style);
        }
    }

    public class MyWizardAeroModel : DevExpress.XtraWizard.WizardViewInfo.WizardAeroModel
    {
        public MyWizardAeroModel(WizardViewInfo viewInfo)
            : base(viewInfo)
        {
            
        }

        public override Rectangle GetContentBounds()
        {
            Rectangle bounds = base.GetContentBounds();
            int widht = ((MyWizard)Wizard).NavParentControl.Width;
            return new Rectangle(bounds.X + widht, bounds.Y, bounds.Width - widht, bounds.Height);
        }
         
    }
}
