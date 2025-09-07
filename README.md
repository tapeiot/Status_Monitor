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
1. เข้าไปที่ https://drive.google.com/drive/folders/1xrcUc9Nugq2-NuKPiKqwmxaCtbNsGyBB
2. เลือก Download ระหว่าง .exe หรือ setup.exe
3. หากใช้แบบ setup.exe เมื่อ Download เรียบร้อยให้คลิกเข้าไปเพื่อทำการติดตั้ง
4. เลือก path ที่จะเก็บไฟล์ </br>
<img width="604" height="471" alt="image" src="https://github.com/user-attachments/assets/96c1913c-1505-4e80-a990-f062384470ef" /></br>
5. จากนั้นกดติดตั้งแล้วรอ </br>
<img width="602" height="468" alt="image" src="https://github.com/user-attachments/assets/cb4b3aec-797c-4707-b299-6fb5525cf9f2" /></br>
<img width="606" height="466" alt="image" src="https://github.com/user-attachments/assets/20c7c258-f14e-41f1-b627-5d7b322b83fc" /></br>
6. เป็นอันเสร็จ</br>
<img width="603" height="465" alt="image" src="https://github.com/user-attachments/assets/2e9c3fb9-809c-488c-9237-d77c33af4b96" /></br>

## ตัวอย่าง (Example): 
### Login - page </br>
<img width="600" height="600" alt="Screenshot 2025-08-31 220755" src="https://github.com/user-attachments/assets/5461283c-59a6-416f-b84f-9d108aa0aac7" /> </br>
### Operator - page </br>
<img width="600" height="600" alt="Screenshot 2025-09-07 125619" src="https://github.com/user-attachments/assets/c36072e8-ff29-4dbb-ba3d-73f1a6f49667" /> </br>
### TCP/IP - page </br>
<img width="600" height="600" alt="Screenshot 2025-08-31 220835" src="https://github.com/user-attachments/assets/7ede3a45-ddcd-4896-a442-d5a2b9b1bde2" /> </br>
### Register - page </br>
<img width="600" height="600" alt="Screenshot 2025-08-31 220850" src="https://github.com/user-attachments/assets/60af6716-d457-4ea2-bea2-e25fda83f90f" /> </br>
### Setting - page </br>
<img width="600" height="600" alt="Screenshot 2025-08-31 220904" src="https://github.com/user-attachments/assets/886757e9-15bf-42ce-bd64-fc406569e1fd" /> </br>
### Log - page </br>
<img width="600" height="600" alt="Screenshot 2025-08-31 221008" src="https://github.com/user-attachments/assets/1265192f-f771-4272-a7de-0f34c944d712" /> </br>







