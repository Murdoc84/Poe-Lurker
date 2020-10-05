//-----------------------------------------------------------------------
// <copyright file="SkillMessage.cs" company="Wohs Inc.">
//     Copyright © Wohs Inc.
// </copyright>
//-----------------------------------------------------------------------

namespace Lurker.UI.Models
{
    using Lurker.Models;

    /// <summary>
    /// Represents the skill message.
    /// </summary>
    public class SkillMessage : TimelineMessage
    {
        #region Properties

        /// <summary>
        /// Gets or sets the skill.
        /// </summary>
        /// <value>
        /// The skill.
        /// </value>
        public Skill Skill { get; set; }

        #endregion
    }
}