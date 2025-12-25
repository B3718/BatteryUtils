# BatteryUtils（双电池增强版）

本项目基于 [XYUU/BatteryUtils](https://github.com/XYUU/BatteryUtils) 修改，
增加了 **联想 ThinkPad 双电池机型** 的支持（如 T480、T470、X270）。

该工具可通过联想电源管理驱动设置 **电池开始 / 停止充电阈值**，
同时作用于内置电池和外置电池。

[English Version / 英文说明](README.md)

---

## 功能特性

- 设置电池充电开始 / 停止阈值
- 支持 **ThinkPad 双电池架构**
- 轻量级 WinForms 程序
- 无后台服务，无常驻进程

---

## 支持设备

- 采用 **双电池设计** 的联想 ThinkPad 笔记本
  - T480 / T470 / X270 / 及类似型号

⚠️ **不支持单电池机型或非联想设备**

---

## 运行环境

- Windows 8 / Windows 10
- 联想电源管理驱动（`IBMPmDrv`）
- 需要 **以管理员身份运行**

---

## ⚠️ 风险提示（重要）

点击 **Apply** 按钮时，程序会同时向驱动发送以下电池控制指令：

- `0x01` —— 内置电池
- `0x02` —— 外置电池

对于 **单电池设备或非 ThinkPad 设备**，该行为未经验证，
可能产生不可预期的后果。

**请自行承担使用风险。**

---

## 下载

请前往 **Releases** 页面下载已编译版本：

- `BatteryUtils-net35.exe` —— .NET Framework 3.5
- `BatteryUtils-net40.exe` —— .NET Framework 4（推荐）

---

## 致谢

原始项目作者：**XYUU**  
https://github.com/XYUU/BatteryUtils

本分支在原项目基础上增加了双电池支持，并进行了结构重构。
