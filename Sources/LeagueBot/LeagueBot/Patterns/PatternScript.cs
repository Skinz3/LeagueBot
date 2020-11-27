﻿using LeagueBot.Api;

namespace LeagueBot.Patterns
{
    public abstract class PatternScript
    {
        public BotApi Bot { get; internal set; }

        public ClientApi Client { get; internal set; }

        public GameApi Game { get; internal set; }

        public virtual bool ThrowException => true;

        public abstract void Execute();

        // TODO: Called on Ending the script
        public virtual void OnEnd()
        {
        }
    }
}