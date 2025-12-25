# BatteryUtils (Dual Battery Fork)

A fork of [XYUU/BatteryUtils](https://github.com/XYUU/BatteryUtils) with **dual-battery support**
for Lenovo ThinkPad laptops (e.g. T480, T470, X270).

This tool allows setting **start / stop charging thresholds**
for both internal and external batteries via Lenovo's power management driver.

[中文说明 / Chinese Version](ReadMe.zh-CN.md)

---

## Features

- Set charge start / stop thresholds
- Supports **dual-battery ThinkPad models**
- Lightweight WinForms application
- No background service required

---

## Supported Devices

- Lenovo ThinkPad laptops with **dual-battery design**
  - T480 / T470 / X270 / similar models

⚠️ Single-battery or non-Lenovo devices are **not supported**.

---

## Requirements

- Windows 8 / Windows 10
- Lenovo Power Management Driver (`IBMPmDrv`)
- Run as **Administrator**

---

## ⚠️ Warning

When clicking **Apply**, the program sends charge threshold commands to **both battery IDs**:

- `0x01` — Internal battery
- `0x02` — External battery

On single-battery systems or unsupported devices, this behavior is untested and may cause
undefined behavior.

**Use at your own risk.**

---

## Downloads

See the **Releases** page for prebuilt binaries:

- `BatteryUtils-net35.exe` — .NET Framework 3.5
- `BatteryUtils-net40.exe` — .NET Framework 4 (recommended)

---

## Credits

Original project by **XYUU**:  
https://github.com/XYUU/BatteryUtils

This fork adds dual-battery support and refactors the code for maintainability.

