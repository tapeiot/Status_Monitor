## ชื่อและคำอธิบาย (Name and Description): 
Status Monitoring - Desktop application C# 
  1.	เชื่อมต่อเครื่องผ่าน TCP/IP ตัวอย่าง IP: 192.168.1.90: 3012 โดยต้องสามารถส่งได้ทั้งหมด 9 เครื่อง มี Tab ให้แก้ไข IP และ Port ของเครื่อง
  2.	กดปุ่มเพื่อ List งานในตัวเครื่อง - List งานในตัวเครื่องจะอยู่มาใน Drop Down
  3.	ดูจำนวน Field ใน Job ที่เลือก
  4.	เมื่อแสดง Field แล้ว เลือก Field ที่กำหนด ให้ Edit โดยจะสร้างจาก Job ที่ Fix Name ไว้ในตัวเครื่อง 
  5.	Format Field ที่สามารถใส่ไปได้ใน</br>
	DD = ใส่ได้เฉพาะวันที่ 01 - 31</br>
    MON = ใส่ได้เฉพาะเดือน JAN / FEB / MAR / APR / MAY / JUN / JUL / AUG / SEP / OCT / NOV / DEC </br>
    YEAR = ใส่ได้เฉพาะปี 4 ตัวอักษร (Numeric)</br>
  6.	เลือกโหลด Variable เพื่อเตรียมส่งไปที่ ไฟล์งาน เปลี่ยน Format
  7.	เลือกเครื่องที่จะทำการส่ง JOB โดยอาจไม่ส่งทั้งหมด 9 เครื่อง
  8.	กดปุ่มเพื่อ ส่ง งานในตัวเครื่อง ตามเครื่องที่เลือก
  9.	กดปุ่มเพื่อ ดูสถานะของตัวเครื่อง </br>
    สีแสดงสภานะของตัวเครื่อง</br> 
    0 Shut down - แดง </br>
    1 Starting up - ฟ้า </br>
    2 Shutting down - เหลือง </br>
    3 Running - เขียว</br>
    4 Offline - เทา "</br>
	กดปุ่มเดี่ยวเพื่อแสดงสถานะทั้ง หมด </br>
  10.	กดปุ่มเพื่อเปิดหน้าจอของตัวเครื่อง </br>
    - ผ่าน Web Browser Google Chrome โดยไปเลือกเปิด Short Cut ที่เก็บไว้ใน Folder </br>
    - ผ่าน RealVNC โดยไปเลือกเปิด Short Cut ที่เก็บไว้ใน Folder </br>
    - มี TAB ให้เลือก PATH ที่ลิงค์กับปุ่มได้ </br>
  11.	กดปุ่มเพื่อเปิดหน้าจอของตัวเครื่อง </br>
    - ผ่าน Web Browser Google Chrome โดยไปเลือกเปิด .html ที่ทำ Site ไว้ </br>
    - มี TAB ให้เลือก PATH ที่ลิงค์กับปุ่มได้ </br>
  12.	มี TAB ให้ดู Log ของ TCP/IP Communication ที่ส่งออกไปได้ 
  13.	เพิ่ม Nickname เพื่อตั้งชื่อเล่นของเครื่องได้ ในหน้า ที่กำหนด IP และ Port 
  14.	เพิ่ม User สามารถ Login ได้ </br>
    - User: ได้เฉพาะหน้า Operation </br>
    - Admin: Config ค่าต่างๆ </br>
  15.	เก็บ Log ไว้ใน Text File .txt


## สถานะของโปรเจกต์ (Project Status): 
🟩 $${\color{green}Complete!}$$

## การติดตั้งและใช้งาน (Installation and Usage): 
วิธีการติดตั้ง
1. โคลน repository นี้: `git clone https://github.com/your-username/your-project.git`
2. เข้าไปในโฟลเดอร์โปรเจกต์: `cd your-project`
3. รันโปรแกรมด้วยคำสั่ง: `dotnet run`
4. 

## ตัวอย่าง (Example): 
หากเป็นไปได้ ควรมีภาพหน้าจอ (Screenshot) หรือไฟล์ GIF แสดงการทำงานของโปรแกรมครับ

