using System;
using System.Collections;
using System.Collections.Generic;

namespace PCG
{
	public class Rule
	{
        public String Name { get; set; }
		public string Text { get; set; }

		public List<Rule> outcomes = new List<Rule>();

		public static List<string> getText(Rule rule, int indent = 0) {
			List<string> text = new List<string> ();

			string formattedText = "";
			for (int i = 0; i < indent; i++) {
				formattedText += "   ";
			}

			formattedText += rule.Text;
			text.Add (formattedText);

			foreach(Rule outcome in rule.outcomes) {
				text.AddRange (getText(outcome, indent + 1));
			}

			return text;
		}

		public Rule() {
		}

		public Rule (string text) {
			Text = text;
		}

	}
}

