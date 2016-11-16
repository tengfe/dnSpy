﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;

namespace dnSpy.Contracts.Hex.Editor {
	[Export(typeof(HexEditorOptionDefinition))]
	sealed class ShowOffsetColumnEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.ShowOffsetColumnId;
		public override bool Default => true;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class ShowValuesColumnEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.ShowValuesColumnId;
		public override bool Default => true;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class ShowAsciiColumnEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.ShowAsciiColumnId;
		public override bool Default => true;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class StartPositionEditorOptionDefinition : HexViewOptionDefinition<HexPosition> {
		public override EditorOptionKey<HexPosition> Key => DefaultHexViewOptions.StartPositionId;
		public override HexPosition Default => 0;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class EndPositionEditorOptionDefinition : HexViewOptionDefinition<HexPosition> {
		public override EditorOptionKey<HexPosition> Key => DefaultHexViewOptions.EndPositionId;
		public override HexPosition Default => HexPosition.MaxEndPosition;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class BasePositionEditorOptionDefinition : HexViewOptionDefinition<HexPosition> {
		public override EditorOptionKey<HexPosition> Key => DefaultHexViewOptions.BasePositionId;
		public override HexPosition Default => 0;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class UseRelativePositionsEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.UseRelativePositionsId;
		public override bool Default => false;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class OffsetBitSizeEditorOptionDefinition : HexViewOptionDefinition<int> {
		public override EditorOptionKey<int> Key => DefaultHexViewOptions.OffsetBitSizeId;
		public override int Default => 0;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class HexValuesDisplayFormatEditorOptionDefinition : HexViewOptionDefinition<HexValuesDisplayFormat> {
		public override EditorOptionKey<HexValuesDisplayFormat> Key => DefaultHexViewOptions.HexValuesDisplayFormatId;
		public override HexValuesDisplayFormat Default => HexValuesDisplayFormat.HexByte;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class HexOffsetFormatEditorOptionDefinition : HexViewOptionDefinition<HexOffsetFormat> {
		public override EditorOptionKey<HexOffsetFormat> Key => DefaultHexViewOptions.HexOffsetFormatId;
		public override HexOffsetFormat Default => HexOffsetFormat.Hex;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class ValuesLowerCaseHexEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.ValuesLowerCaseHexId;
		public override bool Default => false;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class OffsetLowerCaseHexEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.OffsetLowerCaseHexId;
		public override bool Default => false;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class BytesPerLineEditorOptionDefinition : HexViewOptionDefinition<int> {
		public override EditorOptionKey<int> Key => DefaultHexViewOptions.BytesPerLineId;
		public override int Default => 0;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class EnableColorizationEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.EnableColorizationId;
		public override bool Default => true;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class ViewProhibitUserInputEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.ViewProhibitUserInputId;
		public override bool Default => false;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class RefreshScreenOnChangeEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.RefreshScreenOnChangeId;
		public override bool Default => false;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class RefreshScreenOnChangeWaitMilliSecondsEditorOptionDefinition : HexViewOptionDefinition<int> {
		public override EditorOptionKey<int> Key => DefaultHexViewOptions.RefreshScreenOnChangeWaitMilliSecondsId;
		public override int Default => DefaultHexViewOptions.DefaultRefreshScreenOnChangeWaitMilliSeconds;
		public override bool IsValid(ref int proposedValue) => proposedValue >= 0;
	}

	[Export(typeof(HexEditorOptionDefinition))]
	sealed class RemoveExtraTextLineVerticalPixelsEditorOptionDefinition : HexViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultHexViewOptions.RemoveExtraTextLineVerticalPixelsId;
		public override bool Default => false;
	}
}
