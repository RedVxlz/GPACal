# GPA Calculator

## Overview
โปรแกรม **GPA Calculator** ใช้สำหรับคำนวณค่าเฉลี่ย GPA, ค่าต่ำสุด, ค่าสูงสุด และจำนวนข้อมูลที่รับเข้ามา โดยใช้ **C# Windows Forms**  

## Class Diagram
```mermaid
classDiagram
    class GPACalculator {
        +double gpa_sum
        +int n
        +double gpa_min
        +double gpa_max
        +void setGPA(double gpa)
        +double getMaxGPA()
        +double getMinGPA()
        +double getGPAX()
        +int getStudentCount()
    }
    
    class Form1 {
        +GPACalculator gPACalculator
        +TextBox tbInputGpa
        +TextBox tbGpaX
        +TextBox tbGpaMax
        +TextBox tbGpaMin
        +TextBox tbStudentCount
        +Button btnAdd
        +Button btnClear
        +void btnAdd_Click(object sender, EventArgs e)
        +void btnClear_Click(object sender, EventArgs e)
        +void UpdateUI()
    }

    Form1 --> GPACalculator : uses
```