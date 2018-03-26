﻿using System.Collections.Generic;

namespace API
{
    public class ScenarioList
    {
        private List<Scenario> m_Scenarios;

        public ScenarioList()
        {
            m_Scenarios = new List<Scenario>();
        }

        public ScenarioList(List<Scenario> scenarios)
        {
            m_Scenarios = scenarios;
        }

        public ScenarioList(ScenarioList scenarioList)
        {
            m_Scenarios = scenarioList.GetScenarios();
        }

        public List<Scenario> GetScenarios()
        {
            return m_Scenarios;
        }

        public void SetScenarios(List<Scenario> scenarios)
        {
            m_Scenarios = scenarios;
        }
    }

    public class Scenario
    {
        /// <summary>
        /// The list of choices that can be made from this scenario.
        /// </summary>
        private List<Choice> m_Choices;

        /// <summary>
        /// If null string, black screen. 
        /// If video path but wrong, then display error.
        /// </summary>
        private string m_VideoPath;

        /// <summary>
        /// If null string, no sound. 
        /// Indicates the file path for the ambient sound file for the scenario.
        /// </summary>
        private string m_AmbientSoundPath;

        /// <summary>
        /// If null string, no sound. 
        /// Indicates the file path for the sound effect file for the scenario.
        /// </summary>
        private string m_SoundEffectPath;

        /// <summary>
        /// Null indicates no scenario text.
        /// </summary>
        private string m_ScenarioText;

        /// <summary>
        /// Sets emergency lighting intensity.
        /// </summary>
        private int m_LightingIntensity;

        /// <summary>
        /// The ambient sound volume as a percentage (i.e. between 1 and 100).
        /// </summary>
        private int m_AmbientVolume;

        /// <summary>
        /// The sound effect volume as a percentage (i.e. between 1 and 100).
        /// </summary>
        private int m_EffectVolume;

        /// <summary>
        /// Indicates the presence of a fire effect in the scenario.
        /// </summary>
        private bool m_FireBool;

        /// <summary>
        /// Indicates that the scenario has a smoke effect.
        /// </summary>
        private bool m_SmokeBool;

        /// <summary>
        /// Indicates that the extinguisher effect should be activated. 
        /// </summary>
        private bool m_ExtinguisherBool;

        public Scenario()
        {
            m_Choices = new List<Choice>();

            m_VideoPath = string.Empty;
            m_AmbientSoundPath = string.Empty;
            m_SoundEffectPath = string.Empty;
            m_ScenarioText = string.Empty;

            m_LightingIntensity = 0;
            m_AmbientVolume = 0;
            m_EffectVolume = 0;

            m_FireBool = false;
            m_SmokeBool = false;
            m_ExtinguisherBool = false;
        }

        public Scenario(Scenario scenario)
        {
            m_Choices = scenario.GetChoices();

            m_VideoPath = scenario.GetVideoPath();
            m_AmbientSoundPath = scenario.GetAmbientSoundPath();
            m_SoundEffectPath = scenario.GetSoundEffectPath();
            m_ScenarioText = scenario.GetScenarioText();

            m_LightingIntensity = scenario.GetLightingIntensity();
            m_AmbientVolume = scenario.GetAmbientVolume();
            m_EffectVolume = scenario.GetEffectVolume();

            m_FireBool = scenario.GetFireBool();
            m_SmokeBool = scenario.GetSmokeBool();
            m_ExtinguisherBool = scenario.GetExtinguisherBool();
        }

        public Scenario(List<Choice> choices, string videoPath, string ambientSoundPath, string soundEffectPath, string scenarioText, int lightingIntensity, int ambientVolume, int effectVolume, bool fireBool, bool smokeBool, bool extinguisherBool)
        {
            m_Choices = choices;

            m_VideoPath = videoPath;
            m_AmbientSoundPath = ambientSoundPath;
            m_SoundEffectPath = soundEffectPath;
            m_ScenarioText = scenarioText;

            m_LightingIntensity = lightingIntensity;
            m_AmbientVolume = ambientVolume;
            m_EffectVolume = effectVolume;

            m_FireBool = fireBool;
            m_SmokeBool = smokeBool;
            m_ExtinguisherBool = extinguisherBool;
        }

        public List<Choice> GetChoices()
        {
            return m_Choices;
        }

        public string GetVideoPath()
        {
            return m_VideoPath;
        }

        public string GetAmbientSoundPath()
        {
            return m_AmbientSoundPath;
        }

        public string GetSoundEffectPath()
        {
            return m_SoundEffectPath;
        }

        public string GetScenarioText()
        {
            return m_ScenarioText;
        }

        public int GetLightingIntensity()
        {
            return m_LightingIntensity;
        }

        public int GetAmbientVolume()
        {
            return m_AmbientVolume;
        }

        public int GetEffectVolume()
        {
            return m_EffectVolume;
        }

        public bool GetFireBool()
        {
            return m_FireBool;
        }

        public bool GetSmokeBool()
        {
            return m_SmokeBool;
        }

        public bool GetExtinguisherBool()
        {
            return m_ExtinguisherBool;
        }

        public void SetChoices(List<Choice> choices)
        {
            m_Choices = choices;
        }

        public void SetVideoPath(string videoPath)
        {
            m_VideoPath = videoPath;
        }

        public void SetAmbientSoundPath(string ambientSoundPath)
        {
            m_AmbientSoundPath = ambientSoundPath;
        }

        public void SetSoundEffectPath(string soundEffectPath)
        {
            m_SoundEffectPath = soundEffectPath;
        }

        public void SetScenarioText(string scenarioText)
        {
            m_ScenarioText = scenarioText;
        }

        public void SetLightingIntensity(int lightingIntensity)
        {
            m_LightingIntensity = lightingIntensity;
        }

        public void SetAmbientVolume(int ambientVolume)
        {
            m_AmbientVolume = ambientVolume;
        }

        public void SetFireBool(bool fireBool)
        {
            m_FireBool = fireBool;
        }

        public void SetSmokeBool(bool smokeBool)
        {
            m_SmokeBool = smokeBool;
        }

        public void SetExtinguisherBool(bool extinguisherBool)
        {
            m_ExtinguisherBool = extinguisherBool;
        }
    }

    public class Choice
    {
        /// <summary>
        /// The scenario that the choice should. 
        /// </summary>
        private Scenario m_NextScenario;

        /// <summary>
        /// The choice associated with the text.
        /// </summary>
        private string m_ChoiceText;

        /// <summary>
        /// The feedback given at the end if this choice has been made.
        /// </summary>
        private string m_FeedbackText;

        /// <summary>
        /// Positive choice - positive score
        /// Negative choice - negative score
        /// Neutral choice/no decision needed - zero
        /// </summary>
        private int m_Score;

        public Choice()
        {
            m_NextScenario = null;

            m_ChoiceText = string.Empty;
            m_FeedbackText = string.Empty;

            m_Score = 0;
        }

        public Choice(Choice choice)
        {
            m_NextScenario = choice.GetNextScenario();

            m_ChoiceText = choice.GetChoiceText();
            m_FeedbackText = choice.GetFeedbackText();

            m_Score = choice.GetScore();
        }

        public Choice(Scenario nextScenario, string choiceText, string feedbackText, int score)
        {
            m_NextScenario = nextScenario;

            m_ChoiceText = choiceText;
            m_FeedbackText = feedbackText;

            m_Score = score;
        }

        public Scenario GetNextScenario()
        {
            return m_NextScenario;
        }

        public string GetChoiceText()
        {
            return m_ChoiceText;
        }

        public string GetFeedbackText()
        {
            return m_FeedbackText;
        }

        public int GetScore()
        {
            return m_Score;
        }

        public void SetNextScenario(Scenario nextScenario)
        {
            m_NextScenario = nextScenario;
        }

        public void SetChoiceText(string choiceText)
        {
            m_ChoiceText = choiceText;
        }

        public void SetFeedbackText(string feedbackText)
        {
            m_FeedbackText = feedbackText;
        }

        public void SetScore(int score)
        {
            m_Score = score;
        }
    }
}