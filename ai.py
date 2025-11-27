import requests
import whisper 
import os
from moviepy.video.io.VideoFileClip import VideoFileClip
import time
while(True):
     
        var=""
        file=None
        
        def check():
            while(True):

                if(os.path.exists("D:/AiPath/samples.txt")):
                    print("found something")
                    global file
                    file=open("D:/AiPath/samples.txt","r")
                    global var
                    var=file.read()
                    file.close()
                    files= open("D:/auth/fileFound.txt","w")
                    files.close()
                    
                    break
                    
                else:
                    time.sleep(0.5)
                    print("nothing")    
        check()
        try:
            name=var.strip()
            vid=VideoFileClip(f"D:/vid/{name}")
            vid.audio.write_audiofile("aud.wav")
            obj=whisper.load_model("small")
            text=obj.transcribe("aud.wav")
            prompt=text["text"]
            file.close()
            files= open("D:/auth/transcription.txt","w")
            files.close()
            obj={
                "prompt":prompt+"remove ** in response"+"summarize this text",
                "model":"llama3.2",
                "stream":False
            }
            req=requests.post("http://localhost:11434/api/generate",json=obj)
            ans=req.json().get("response")
            print(ans)
            notes=open("D:/notes/notes.txt","w")
           
            notes.write(ans)
            notes.close()   
            files.close()
            saved=open("D:/auth/saved.txt","w")
            saved.close()
            os.remove("D:/AiPath/samples.txt")
            #answer=ans.split("</think>")[1]

        except(FileExistsError):
            notes.write(ans)   
            var.strip()
            print(FileExistsError)
        
      
          
 