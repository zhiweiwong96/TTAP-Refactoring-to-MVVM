﻿using System.Collections.Generic;
using System.Linq;
using Time_Table_Arranging_Program.Class.Converter;

namespace Time_Table_Arranging_Program.Class.TokenParser {
    public class SlotParser {
        public List<Slot> Parse(string input) {
            ITokenStream ts = new TokenStream(Tokenizer.Tokenize(input));
            var finalResult = new List<Slot>();
            var isReadingSubjectName = false;
            var resultSlot = new Slot();
            while (true) {
                if (ts.IsAtLastToken()) break;
                if (TryParseSubjectCode(ts, ref resultSlot)) goto here;
                if (TryParseSubjectName(ts, ref resultSlot, ref isReadingSubjectName)) goto here;
                if (TryParseSlotNumber(ts, ref resultSlot)) goto here;
                if (TryParseSlotType(ts, ref resultSlot)) goto here;
                if (TryParseDay(ts, ref resultSlot)) goto here;
                if (TryParseStartTime(ts, ref resultSlot)) goto here;
                if (TryParseEndTime(ts, ref resultSlot)) goto here;
                if (TryParseWeekAndVenue(ts, ref resultSlot)) {
                    resultSlot.SubjectName = resultSlot.SubjectName.Beautify();
                    if (finalResult.Any(s => s.Equals(resultSlot))) {
                        /*do nothing*/
                    }
                    else {
                        finalResult.Add(resultSlot.GetDuplicate());
                    }
                }

                here:
                ts.GoToNextToken();
                resultSlot.WeekNumber.Clear();
            }
            return finalResult;
        }

        private bool TryParseWeekAndVenue(ITokenStream ts, ref Slot resultSlot) {
            if (!ts.PreviousToken().IsPositiveNumberThatContainDecimalPoint() || !ts.NextToken().IsPossiblyVenuValue())
                return false;
            resultSlot.WeekNumber = WeekNumber.Parse(ts.CurrentToken().Value());
            resultSlot.Venue = ts.NextToken().Value();
            return true;
        }


        private string Beautify(string s) {
            var tokens = s.Split(' ');
            for (var i = 0; i < tokens.Length; i++) {
                if (tokens[i].All(t => t == 'I')) continue;
                if (tokens[i] == "") continue;
                tokens[i] = tokens[i].ToLower();
                tokens[i] = char.ToUpper(tokens[i][0]) + tokens[i].Substring(1, tokens[i].Length - 1);
            }
            var result = "";
            foreach (var t in tokens) {
                result += t + " ";
            }
            return result.Substring(0, result.Length - 1);
        }

        private bool TryParseSubjectCode(ITokenStream ts, ref Slot resultSlot) {
            if (ts.CurrentToken().IsPossiblySubjectCode() && ts.NextToken().Value() == "-") {
                resultSlot.Code = ts.CurrentToken().Value();
                return true;
            }
            return false;
        }

        private bool TryParseEndTime(ITokenStream ts, ref Slot resultSlot) {
            if (ts.CurrentToken().IsTime() && ts.PreviousToken().Value() == "-") {
                resultSlot.EndTime = Time.CreateTime_12HourFormat(ts.CurrentToken().Value(), ts.NextToken().Value());
                return true;
            }
            return false;
        }

        private bool TryParseStartTime(ITokenStream ts, ref Slot resultSlot) {
            if (!ts.CurrentToken().IsTime()) return false;
            if (!ts.PreviousToken().IsDay()) return false;
            resultSlot.StartTime = Time.CreateTime_12HourFormat(ts.CurrentToken().Value(), ts.NextToken().Value());
            return true;
        }

        private bool TryParseDay(ITokenStream ts, ref Slot resultSlot) {
            if (ts.CurrentToken().IsDay()) {
                resultSlot.Day = Day.Parse(ts.CurrentToken().Value());
                //resultSlot.Day = new Day( ts.CurrentToken().Value());
                return true;
            }
            return false;
        }

        private bool TryParseSlotType(ITokenStream ts, ref Slot resultSlot) {
            if (ts.CurrentToken().IsSlotType()) {
                resultSlot.Type = ts.CurrentToken().Value();
                return true;
            }
            return false;
        }

        private bool TryParseSlotNumber(ITokenStream ts, ref Slot resultSlot) {
            if (!ts.CurrentToken().IsPositiveInteger()) return false;
            if (!ts.PreviousToken().IsSlotType()) return false;
            resultSlot.Number = ts.CurrentToken().Value();
            return true;
        }

        private bool TryParseSubjectName(ITokenStream ts, ref Slot resultSlot, ref bool isReadingSubjectName) {
            if (isReadingSubjectName) {
                if (ts.CurrentToken().Value().Length != 0 && ts.CurrentToken().Value()[0] == '[') {
                    isReadingSubjectName = false;
                    return true;
                }
                resultSlot.SubjectName += " " + ts.CurrentToken().Value();
                return true;
            }

            if (ts.CurrentToken().Value() == "-" && ts.PreviousToken().IsPossiblySubjectCode()) {
                isReadingSubjectName = true;
                resultSlot.SubjectName = "";
                return true;
            }

            return false;
        }
    }
}