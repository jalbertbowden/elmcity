﻿/* ********************************************************************************
 *
 * Copyright 2010-2013 Microsoft Corporation
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you
 * may not use this file except in compliance with the License. You may
 * obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 
 * Unless required by applicable law or agreed to in writing, software distributed 
 * under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License. 
 *
 * *******************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using ElmcityUtils;
using Ionic.Zip;

namespace CalendarAggregator
{
	public interface IAction<TCommand>
	{
		bool Validate(TCommand command);

		bool Perform(TCommand command, string id);

		void Complain(TCommand command, string complaint);

		void Confirm(TCommand command, string confirmation);
	}

	/*

	public class TwitterAction : IAction<TwitterCommand>
	{
		public virtual bool Validate(TwitterCommand twitter_command)
		{
			if (twitter_command.command == TwitterCommandName.none)
			{
				this.Complain(twitter_command, "message didn't start with a command verb");
				return false;
			}
			var args_include_required = twitter_command.required_args.IsSubsetOf<string>(twitter_command.args_dict.Keys.ToList());
			if (args_include_required == false)
			{
				this.Complain(twitter_command, "all required args not included");
				return false;
			}

			return true;
		}

		public virtual bool Perform(TwitterCommand command, string id)
		{
			return false;
		}

		public void Complain(TwitterCommand command, string complaint)
		{
			var text = command.text.SingleQuote();
			GenUtils.PriorityLogMsg("action", command.sender_screen_name + " " + text, complaint);
			complaint += " " + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; // to differentiate otherwise same messages
			TwitterApi.SendTwitterDirectMessage(command.sender_screen_name, complaint);
		}

		public void Confirm(TwitterCommand command, string confirmation)
		{
			var text = command.text.SingleQuote();
			GenUtils.LogMsg("action", command.sender_screen_name + " " + text, confirmation);
			TwitterApi.SendTwitterDirectMessage(command.sender_screen_name, confirmation);
		}

		public bool CheckUri(TwitterCommand command, string url )
		{
			Uri uri;
			try
			{
				uri = new Uri(url);
			}
			catch (System.UriFormatException)
			{
				this.Complain(command, "bad format " + url);
				return false;
			}
			try
			{
				var r = HttpUtils.FetchUrl(uri);
				if (r.status != System.Net.HttpStatusCode.OK)
				{
					this.Complain(command, r.status.ToString() + " " + uri.ToString());
					return false;
				}
				if (r.status == System.Net.HttpStatusCode.OK && r.DataAsString().Contains("not a valid user id")) // bad fb uid
				{
					this.Complain(command, r.DataAsString());
					return false;
				}
				if (r.status == System.Net.HttpStatusCode.OK && r.DataAsString().Contains("URL is invalid or has expired")) // bad fb key
				{
					this.Complain(command, r.DataAsString());
					return false;
				}

			}
			catch 
			{
				this.Complain(command, "problem with " + uri.ToString());
				return false;
			}
			return true;
		}
	}

	// Supports http://blog.jonudell.net/2011/06/02/syndicating-facebook-events/
	// Idle for now, but mechanism available for other use
	public class AddFacebookFeed : TwitterAction
	{
		public override bool Validate(TwitterCommand command)
		{
			if (base.Validate(command) == false)
				return false;

			var url = String.Format("http://www.facebook.com/ical/u.php?uid={0}&key={1}", command.args_dict["id"], command.args_dict["key"]);
			if (CheckUri(command, url) == false)
				return false;

			if ( command.all_args.Contains("url") && CheckUri(command, command.args_dict["url"]) == false )
				return false;

			this.Confirm(command, "elmcity received your " + command.command + " command");

			return true;
		}

		public override bool Perform(TwitterCommand command, string id)
		{
			if (this.Validate(command) == false)
				return false;

			var metadict = new Dictionary<string, object>();
			metadict["feedurl"] = String.Format("http://www.facebook.com/ical/u.php?uid={0}&key={1}", command.args_dict["id"], command.args_dict["key"]);
			metadict["facebook_organizer"] = command.args_dict["who"].Replace('+', ' ');
			metadict["source"] = String.Format("{0}'s Facebook events", metadict["facebook_organizer"]);
			metadict["private"] = true;

			if (command.args_dict.ContainsKey("url"))
				metadict["url"] = command.args_dict["url"];

			if (command.args_dict.ContainsKey("category"))
				metadict["category"] = command.args_dict["category"];

			try
			{
				Metadata.StoreFeedAndMetadataToAzure(id, (string)metadict["feedurl"], metadict);
			}
			catch 
			{
				this.Complain(command, "unable to add facebook feed");
				return false;
			}

			this.Confirm(command, "facebook feed successfully added");
			return true;
		}

	}
	 */

}
