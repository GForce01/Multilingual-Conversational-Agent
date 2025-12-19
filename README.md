# VR Session With Multilingual Virtual Agent
This is a VR icebreaker session with a multilingual conversational virtual agent aimed 
## Setup instructions
Most of the scripts that requires setting up were attached to the AIManager object in the scene. Additionally, the gaze model was attached to the avatar's root and the lip-sync attached to it's head.

### Setting up the API key
This project is based on OpenAI's online service, so an OpenAI API key is required.
For simplicity, the project keeps the API key with a local parameter instead of reading it through an environment variable.
*Some extra caution is advised to prevent key leak!*

To start, go to Assets/Scripts/APIKeys.cs and replace the string with your own key.

##### IMPORTANT SAFTY WARNING
API keys should ***Always be kept secret*** and never shared. To avoid accidently commiting to online repo, as soon as you pulled the repo, run the following command:
```
git update-index --assume-unchanged Assets/Scripts/APIKeys.cs
```
This will let git ignore the changes to the APIKeys script.

##### API cost
Although the API usage isn't free, the cost of this project is quite low. As a reference, the development and 10 pilot sessions together only cost $0.28.

### Setting up the Transcribe service
First locate the Transcribe component on the AIManager, there are various setting that might worth playing with.

*The Model field is the name of the model called for the transcription task, leaving it with whisper-1 should be fine.
*The Translation check box determines if the model should translate all the input into English or should it output with the original language.

#### Setting up the mic

#### Choosing language

### System promp & structured reply

### Model config

### Other settings

## Research paper
https://dl.acm.org/doi/10.1145/3717511.3749308
