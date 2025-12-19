# VR Session With Multilingual Virtual Agent
This is a VR icebreaker session with a multilingual conversational virtual agent aimed 
# Setup instructions
Most of the scripts that requires setting up were attached to the AIManager object in the scene. Additionally, the gaze model was attached to the avatar's root and the lip-sync attached to it's head.

## Setting up the API key
This project is based on OpenAI's online service, so an OpenAI API key is required.
For simplicity, the project keeps the API key with a local parameter instead of reading it through an environment variable.
*Some extra caution is advised to prevent key leak!*

To start, go to Assets/Scripts/APIKeys.cs and replace the string with your own key.

### IMPORTANT SAFTY WARNING
API keys should ***Always be kept secret*** and never shared. To avoid accidently commiting to online repo, as soon as you pulled the repo, run the following command:
```
git update-index --assume-unchanged Assets/Scripts/APIKeys.cs
```
This will let git ignore the changes to the APIKeys script.

### API cost
Although the API usage isn't free, the cost of this project is quite low. As a reference, the development and 10 pilot sessions together only cost $0.28.

## Setting up the Transcribe service
First locate the Transcribe component on the AIManager, there are various setting that might worth playing with. The Model field shows the name of the model called for the transcription task, whisper-1 is fine. The trim settings controls how slience were trimed from the recording.

### Choosing up the mic
In the *preffered device* list, type in a series of device names by order to compare with exsisting device list. All the names should be in **UPPER CASE**.

Alternatively, you can run the project once and search for "Mic" in the console to check the logged device name list.

### Choosing language & translation
Select a language in the *Language Mode* section to set a preffered transcription language. In a multilanguage FLA training scenario, this should match the language that the participant use during the session.
* Note that this does not strictly limit the resulting language, it only sets a bias to language recognition.
If the model cofidently detects a different language it will still output in that specific language. In practice, closer language like Portuguese and Spanish may be cofused with wrong language mode, but drastically different language like Chinese and German will not be much affected.

More language can be added through script, check the annotation for more information.

The *Translation* option determins whether the model will attempt to translate everything to English or transcribe with the detected language.

## Setting up the Dialogue Manager
The LLM Dialogue Manager component holds most of the options for the conversation with the LLM.

Under Model Settings, there are useful parameters to choose models, coversation historys and token limits. Check [https://platform.openai.com/docs/api-reference/chat](OpenAI API Reference) for a better understanding.

### System prompt & structured reply
The system prompt defines the default settings and knowledge of the LLM instance, it may contains information such as personalities, tasks, environment context, and even the agent's native language.

To costomize the system prompt, write it down in a .txt file and assign it to the *System Prompt Asset*.

The JSON schema allows the LLM to output in a predefined format. Read [https://platform.openai.com/docs/guides/structured-outputs?api-mode=chat](this) for a better explaination.

## Model config

## Other settings


## Research paper
https://dl.acm.org/doi/10.1145/3717511.3749308
