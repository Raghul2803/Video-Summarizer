# 🎥 Offline Video Summarization System
## 📌 Overview
This project introduces an offline video summarization tool built using **Unity**, **Python**, **Whisper**, and **Ollama (LLM)**.
The system extracts audio from a video, converts speech to text, and generates an abstractive summary using a Local Large Language Model — ensuring **speed, privacy, and no cloud dependency**.

## ✨ Key Features
* 🔊 **Offline Speech-to-Text** using Whisper
* 🧠 **Abstractive Summarization** through Ollama 3B model
* 🎛️ **User-Friendly Unity UI** for video selection and result viewing
* 🔐 **Privacy-Preserved Local Processing**
* 📝 Summary export in `.txt` format
* 🎬 Works with most common video formats (MP4, MKV, AVI...)

## 🛠️ Tech Stack

| Layer               | Technology Used      |
| ------------------- | -------------------- |
| UI & Frontend       | Unity                |
| Backend Processing  | Python               |
| Audio Extraction    | FFmpeg / MoviePy     |
| Speech Recognition  | Whisper (OpenAI)     |
| Summarization Model | Ollama Local LLM     |
| Communication       | IPC (Python ↔ Unity) |


## 📂 System Workflow

1. User selects a video from Unity
2. Unity sends path to Python backend
3. Audio extracted using FFmpeg
4. Whisper generates transcript
5. Transcript cleaned & structured
6. Ollama produces abstractive summary
7. Summary displayed or saved to Notepad


## 🧩 Installation & Setup

### Requirements

* Python 3.10+
* Unity 2021 or later
* Whisper installed locally
* Ollama installed with supported 3B model
* FFmpeg installed and added to system PATH

### Python Dependencies

```bash
pip install openai-whisper moviepy ffmpeg-python
```

### Whisper Model Installation

```bash
whisper --model medium
```

### Ollama Model Setup

```bash
ollama run llama2
```

---

## ▶️ How to Run the System

1. Open Unity and run the main scene
2. Browse & choose a video file
3. Click *Generate Summary*
4. Wait for transcript + summarization
5. View the summary in the Unity UI or export to `.txt`

---

## 📊 Performance

* Handles short to long-duration videos
* Summarization quality depends on audio clarity and speech style
* Fully offline processing ensures secure content usage

---

## 🚀 Future Enhancements

* Multilingual transcription and summarization
* Real-time summarization support
* Topic-based segmentation
* UI enhancements with keyword extraction
* Batch processing for multiple videos


## 🏆 Acknowledgments

* OpenAI Whisper for offline ASR
* Ollama for local LLM execution
* Unity for Interaction Interface

