using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse.Models
{
    [Serializable]
    public abstract class ElfBase
    {
        #region 字段
        protected string _elfName = "";
        protected string _elfNote = "";
        #endregion

        #region 属性
        public virtual string ElfName
        {
            get { return _elfName; }
            set { _elfName = value; }
        }

        public virtual string ElfNote
        {
            get { return _elfNote; }
            set { _elfNote = value; }
        }
        #endregion

        #region 方法
        public ElfBase()
        {
        }

        public abstract void Spellcast();

        public abstract Form GetSettingForm();
        #endregion
    }
}
