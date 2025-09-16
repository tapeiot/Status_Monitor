using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Helpers
{
    public class FormManager
    {
        // สร้าง Dictionary เพื่อเก็บฟอร์มที่เคยเปิดแล้ว
        private static Dictionary<Type, Form> _openForms = new Dictionary<Type, Form>();

        // สร้างเมธอดใหม่ที่ฉลาดขึ้น
        public static void OpenForm<T>(Form currentForm) where T : Form, new()
        {
            // ซ่อนฟอร์มปัจจุบันก่อน
            currentForm.Hide();

            Form nextForm;

            // ตรวจสอบว่าเคยสร้างฟอร์มประเภทนี้เก็บไว้ใน Dictionary แล้วหรือยัง
            if (_openForms.ContainsKey(typeof(T)))
            {
                // ถ้าเคยสร้างแล้ว ให้ดึงฟอร์มตัวเก่าออกมา
                nextForm = _openForms[typeof(T)];
            }
            else
            {
                // ถ้ายังไม่เคยสร้าง ให้สร้างฟอร์มใหม่ขึ้นมาเป็นครั้งแรก
                nextForm = new T();
                // และเพิ่มเข้าไปใน Dictionary เพื่อเก็บไว้ใช้ครั้งต่อไป
                _openForms.Add(typeof(T), nextForm);
            }

            // แสดงฟอร์มเป้าหมาย
            nextForm.Show();
        }
    }
}
