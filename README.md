# 🧶 Museum Tenun Interaktif XR

Proyek ini merupakan simulasi museum virtual berbasis **XR (Extended Reality)** menggunakan **Unity 6.1** dan **XR Interaction Toolkit**, yang menghadirkan pengalaman imersif untuk mengenal lebih dekat kain tenun tradisional Indonesia melalui interaksi visual, audio, dan fisik.

---

## 🎮 Fitur Utama

- 🧵 **Interaksi XR Grab**: Pegang dan amati objek tenun dari segala sudut.
- 🎙️ **Audio Narasi Otomatis**: Narasi aktif saat objek dipegang, menjelaskan latar belakang budaya.
- 🖼️ **Interaksi Realistis**: Sistem collider disesuaikan agar objek tidak saling terpental.
- 🔁 **Reset Otomatis**: Objek akan kembali ke posisi semula setelah dilepas.
- 🌐 **Dukungan Bahasa**: Narasi tersedia dalam Bahasa Indonesia, Bali, dan Inggris *(opsional)*.
- 📐 **Desain Modular**: Mudah ditambahkan objek baru seperti kain, alat tenun, atau video dokumenter.

---

## 🛠️ Teknologi

- [Unity 6.1](https://unity.com/)
- XR Interaction Toolkit v3+
- Unity Input System
- C# scripting
- FBX 3D assets & mesh colliders

---


---

## 🚀 Cara Menjalankan

1. **Buka Unity 6.1**, lalu open folder project ini.
2. Pastikan paket berikut sudah ter-install:
   - `XR Interaction Toolkit`
   - `Input System`
3. Buka scene `MuseumTenun.unity`.
4. Jalankan menggunakan device XR (atau simulator).
5. Arahkan laser ke objek, lalu grab objek tenun untuk mendengarkan narasi.

---

## 🧪 Catatan Teknis

- **Collider Plane**: Gunakan `Box Collider` + Rigidbody.
- **Collider Frame**: Gunakan `Mesh Collider` tanpa Rigidbody.
- **Grab Target**: Tempel script `GrabPlayAudio.cs` ke objek plane.
- **Reset Posisi**: Gunakan `ReturnToStartAfterGrab.cs` pada objek yang di-grab.
- Pastikan Rigidbody menggunakan `isKinematic = true` saat reset.

---

## 📸 Preview

*(Tambahkan screenshot atau GIF dari experience XR-nya di sini)*

---

## 📌 Catatan Pengembangan

Fitur lanjutan yang bisa ditambahkan:
- 🗣️ Voice recognition untuk menjawab pertanyaan pengunjung
- 📷 Kamera XR untuk menangkap momen favorit pengguna
- 🌍 Lokasi interaktif berdasarkan daerah asal tenun (Sumba, Bali, dll)

---

## 📃 Lisensi

Proyek ini dibuat untuk keperluan edukasi dan pelestarian budaya Indonesia.  
Lisensi: **MIT License**

---

## 🤝 Kontribusi

Silakan fork, pull request, atau kirim issue untuk peningkatan lebih lanjut!

