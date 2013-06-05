﻿using System;

namespace AngleSharp.Css
{
    /// <summary>
    /// The bracket token that contains the opening or closing of a bracket.
    /// </summary>
    class CssBracketToken : CssToken
    {
        #region Static instances

        readonly static CssBracketToken roundOpen = new CssBracketToken { _type = CssTokenType.RoundBracketOpen, _mirror = CssTokenType.RoundBracketClose };
        readonly static CssBracketToken roundClose = new CssBracketToken { _type = CssTokenType.RoundBracketClose, _mirror = CssTokenType.RoundBracketOpen };
        readonly static CssBracketToken curlyOpen = new CssBracketToken { _type = CssTokenType.CurlyBracketOpen, _mirror = CssTokenType.CurlyBracketClose };
        readonly static CssBracketToken curlyClose = new CssBracketToken { _type = CssTokenType.CurlyBracketClose, _mirror = CssTokenType.CurlyBracketOpen };
        readonly static CssBracketToken squareOpen = new CssBracketToken { _type = CssTokenType.SquareBracketOpen, _mirror = CssTokenType.SquareBracketClose };
        readonly static CssBracketToken squareClose = new CssBracketToken { _type = CssTokenType.SquareBracketClose, _mirror = CssTokenType.SquareBracketOpen };

        #endregion

        #region Members

        CssTokenType _mirror;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new CSS bracket token.
        /// </summary>
        private CssBracketToken()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the bracket symbol that opens this block.
        /// </summary>
        public char Open
        {
            get
            {
                if (_type == CssTokenType.RoundBracketOpen)
                    return '(';
                else if (_type == CssTokenType.SquareBracketOpen)
                    return '[';
                else
                    return '{';
            }
        }
        /// <summary>
        /// Gets the bracket symbol that closes this block.
        /// </summary>
        public char Close
        {
            get
            {
                if (_type == CssTokenType.RoundBracketOpen)
                    return ')';
                else if (_type == CssTokenType.SquareBracketOpen)
                    return ']';
                else
                    return '}';
            }
        }

        /// <summary>
        /// Gets the mirror token type for the current token.
        /// </summary>
        public CssTokenType Mirror
        {
            get { return _mirror; }
        }

        /// <summary>
        /// Gets a curly bracket open token.
        /// </summary>
        public static CssBracketToken OpenRound
        {
            get { return roundOpen; }
        }

        /// <summary>
        /// Gets a curly bracket close token.
        /// </summary>
        public static CssBracketToken CloseRound
        {
            get { return roundClose; }
        }

        /// <summary>
        /// Gets a curly bracket open token.
        /// </summary>
        public static CssBracketToken OpenCurly
        {
            get { return curlyOpen; }
        }

        /// <summary>
        /// Gets a curly bracket close token.
        /// </summary>
        public static CssBracketToken CloseCurly
        {
            get { return curlyClose; }
        }

        /// <summary>
        /// Gets a square bracket open token.
        /// </summary>
        public static CssBracketToken OpenSquare
        {
            get { return squareOpen; }
        }

        /// <summary>
        /// Gets a square bracket close token.
        /// </summary>
        public static CssBracketToken CloseSquare
        {
            get { return squareClose; }
        }

        #endregion

        #region String Representation

        /// <summary>
        /// Gets a string which represents the original value.
        /// </summary>
        /// <returns>The original value.</returns>
        public override string ToValue()
        {
            switch (_type)
            {
                case CssTokenType.CurlyBracketOpen:
                    return "{";
                case CssTokenType.CurlyBracketClose:
                    return "}";
                case CssTokenType.RoundBracketClose:
                    return ")";
                case CssTokenType.RoundBracketOpen:
                    return "(";
                case CssTokenType.SquareBracketClose:
                    return "]";
                case CssTokenType.SquareBracketOpen:
                    return "[";
            }

            return string.Empty;
        }

        #endregion
    }
}
