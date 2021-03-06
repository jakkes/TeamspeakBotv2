﻿using System;
using TeamspeakBotv2.Core;
using TeamspeakBotv2.Models;

namespace TeamspeakBotv2.Commands
{
    public class CreateChannelCommand : NonCollectCommand
    {
        private string channelName;
        private int parentId;

        /// <summary>
        /// Creates a temporary channel and moves the bot into the channel.
        /// </summary>
        public CreateChannelCommand(string channelName, ChannelModel parent) 
            : this(channelName, parent.ChannelId) { }
        public CreateChannelCommand(string channelName, int parentId)
        {
            this.channelName = channelName;
            this.parentId = parentId;
            this.Message = string.Format("channelcreate channel_name={0} cpid={1}", channelName, parentId);
        }
        public override void HandleResponse(string msg)
        {
            throw new RegexMatchException();
        }
    }
}
