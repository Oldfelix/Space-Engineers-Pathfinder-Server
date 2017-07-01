<?xml version="1.0"?>
<MyObjectBuilder_GuiScreen xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Controls>
    <Controls>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlGrid">
        <Position>
          <X>-0.25</X>
          <Y>-0.15032873</Y>
        </Position>
        <Size>
          <X>0.0</X>
          <Y>0.50083333</Y>
        </Size>
        <Name>Grid</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <ControlTexture>Textures\GUI\Screens\screen_tools_background_blocks.dds</ControlTexture>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <VisualStyle>ToolsBlocks</VisualStyle>
        <DisplayColumnsCount>10</DisplayColumnsCount>
        <DisplayRowsCount>9</DisplayRowsCount>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlList">
        <Position>
          <X>0.28</X>
          <Y>0.019</Y>
        </Position>
        <Size>
          <X>0.27</X>
          <Y>0.7</Y>
        </Size>
        <Name>BlockInfoPanel</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <VisualStyle>Default</VisualStyle>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlTextbox">
        <Position>
          <X>0.175</X>
          <Y>-0.345</Y>
        </Position>
        <Size>
          <X>0.2</X>
          <Y>0.00541666672</Y>
        </Size>
        <Name>SearchItemTextBox</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_CENTER_AND_VERTICAL_CENTER</OriginAlign>
        <TextScale>1</TextScale>
        <TextAlignment>3</TextAlignment>
        <VisualStyle>Default</VisualStyle>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlListbox">
        <Position>
          <X>-0.49</X>
          <Y>0.019</Y>
        </Position>
        <Size>
          <X>0.07</X>
          <Y>0.5</Y>
        </Size>
        <Name>CategorySelector</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <VisibleRows>25</VisibleRows>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlLabel">
        <Position>
          <X>-0.49</X>
          <Y>-0.345</Y>
        </Position>
        <Size>
          <X>0.108351357</X>
          <Y>-0.405032873</Y>
        </Size>
        <Name>CategorySelectorLabel</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <TextEnum>ScreenCubeBuilderBlockCategories</TextEnum>
        <TextScale>0.9</TextScale>
        <Font>Blue</Font>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlLabel">
        <Position>
          <X>0.03</X>
          <Y>-0.345</Y>
        </Position>
        <Size>
          <X>0.108351357</X>
          <Y>-0.405032873</Y>
        </Size>
        <Name>BlockSearchLabel</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_CENTER_AND_VERTICAL_CENTER</OriginAlign>
        <TextEnum>ScreenCubeBuilderBlockSearch</TextEnum>
        <TextScale>0.9</TextScale>
        <Font>Blue</Font>
      </MyObjectBuilder_GuiControlBase>   
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlLabel">
        <Position>
          <X>-0.49</X>
          <Y>-0.415032873</Y>
        </Position>t
        <Size>
          <X>0.108351357</X>
          <Y>0.0253333338</Y>
        </Size>
        <Name>CaptionLabel2</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <TextEnum>ScreenCubeBuilderToolbarConfig</TextEnum>
        <TextScale>0.9</TextScale>
        <Font>Blue</Font>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlLabel">
        <Position>
          <X>-0.49</X>
          <Y>-0.390116463</Y>
        </Position>
        <Size>
          <X>0.3727027</X>
          <Y>0.018666666</Y>
        </Size>
        <Name>LabelSubtitle</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <TextEnum>ScreenCubeBuilderSubtitle</TextEnum>
        <TextScale>0.7</TextScale>
        <Font>Blue</Font>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlLabel">
        <Position>
          <X>-0.28</X>
          <Y>-0.345</Y>
        </Position>
        <Size>
          <X>0.116567574</X>
          <Y>0.0253333338</Y>
        </Size>
        <Name>BlocksLabel</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <TextEnum>ScreenCubeBuilderBuildingBlocks</TextEnum>
        <TextScale>0.9</TextScale>
        <Font>Blue</Font>
      </MyObjectBuilder_GuiControlBase>
      <MyObjectBuilder_GuiControlBase xsi:type="MyObjectBuilder_GuiControlLabel">
        <Position>
          <X>-0.2599561</X>
          <Y>0.377</Y>
        </Position>
        <Size>
          <X>0.06775676</X>
          <Y>0.0306666661</Y>
        </Size>
        <Name>LabelToolbar</Name>
        <BackgroundColor>
          <X>1</X>
          <Y>1</Y>
          <Z>1</Z>
          <W>1</W>
        </BackgroundColor>
        <OriginAlign>HORISONTAL_LEFT_AND_VERTICAL_CENTER</OriginAlign>
        <TextEnum>ScreenCubeBuilderToolbar</TextEnum>
        <TextScale>1.15</TextScale>
        <Font>Blue</Font>
      </MyObjectBuilder_GuiControlBase>
    </Controls>
  </Controls>
  <BackgroundColor>
    <X>0</X>
    <Y>0</Y>
    <Z>0</Z>
    <W>0</W>
  </BackgroundColor>
  <BackgroundTexture>Textures\GUI\Screens\screen_background.dds</BackgroundTexture>
  <Size>
    <X>1</X>
    <Y>1</Y>
  </Size>
  <CloseButtonEnabled>true</CloseButtonEnabled>
  <InfoButtonEnabled>false</InfoButtonEnabled>
  <CloseButtonOffset>
    <X>-0.025</X>
    <Y>0.0650000051</Y>
  </CloseButtonOffset>
</MyObjectBuilder_GuiScreen>