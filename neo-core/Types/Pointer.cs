using System;
using System.Diagnostics;

namespace Neo.Types
{
    /// <summary>
    /// Represents the instruction pointer in the VM, used as the target of jump instructions.
    /// </summary>
    [DebuggerDisplay("Type={GetType().Name}, Position={Position}")]
    public class Pointer : StackItem
    {
        /// <summary>
        /// The <see cref="VM.Script"/> object containing this pointer.
        /// </summary>
        public Script Script { get; }

        /// <summary>
        /// The position of the pointer in the script.
        /// </summary>
        public int Position { get; }

        public override StackItemType Type => StackItemType.Pointer;

        /// <summary>
        /// Create a code pointer with the specified script and position.
        /// </summary>
        /// <param name="script">The <see cref="VM.Script"/> object containing this pointer.</param>
        /// <param name="position">The position of the pointer in the script.</param>
        public Pointer(Script script, int position)
        {
            this.Script = script;
            this.Position = position;
        }

        public override bool Equals(StackItem? other)
        {
            if (other == this) return true;
            if (other is Pointer p) return Position == p.Position && Script == p.Script;
            return false;
        }

        public override bool GetBoolean()
        {
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Script, Position);
        }
    }
}
