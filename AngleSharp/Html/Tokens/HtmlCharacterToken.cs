﻿using System;

namespace AngleSharp.Html
{
    /// <summary>
    /// The character token that contains a series of characters.
    /// </summary>
    class HtmlCharacterToken : HtmlToken
    {
        #region Members

        char _data;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new character token.
        /// </summary>
        public HtmlCharacterToken()
        {
            _data = Specification.NULL;
            _type = HtmlTokenType.Character;
        }

        /// <summary>
        /// Creates a new character token with the given character.
        /// </summary>
        /// <param name="data">The character.</param>
        public HtmlCharacterToken(char data)
        {
            _type = HtmlTokenType.Character;
            _data = data;
        }

        /// <summary>
        /// Creates a new character token with the given characters.
        /// </summary>
        /// <param name="data">The characters.</param>
        public HtmlCharacterToken(string data)
        {
            _type = HtmlTokenType.Character;
            //TODO
            //_data = data;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the data of the character token.
        /// </summary>
        public char Data
        {
            get { return _data; }
        }

        #endregion
    }
}
