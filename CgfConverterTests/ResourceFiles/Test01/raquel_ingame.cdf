<CharacterDefinition>
 <Model File="objects/characters/skeleton_character/basecharacter_skeleton.chr" Material="objects/characters/skeleton_character/baseCharacter_skeleton"/>
 <AttachmentList>
  <Attachment Type="CA_BONE" AName="root" Rotation="0.99999994,0,0,0" Position="0,0,0" BoneName="bip01" Flags="0"/>
  <Attachment Type="CA_BONE" AName="#camera" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="bip01 camera" Flags="0"/>
  <Attachment Type="CA_BONE" AName="prop1" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01 AnimProp1" Flags="0"/>
  <Attachment Type="CA_BONE" AName="prop2" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01 AnimProp2" Flags="0"/>
  <Attachment Type="CA_BONE" AName="stow_primary1" Rotation="0.45956585,-0.39938432,-0.58850104,0.53193778" Position="0.1054255,-0.13254666,1.418255" BoneName="Bip01 Spine2" PA_PendulumType="3" PA_SimulationAxis="0,0.5,0" Flags="0"/>
  <Attachment Type="CA_BONE" AName="stow_primary2" Rotation="0.45956606,-0.39938441,0.5885008,-0.53193778" Position="-0.103432,-0.12515718,1.4191489" BoneName="Bip01 Spine2" PA_PendulumType="3" PA_SimulationAxis="0,0.5,0" Flags="0"/>
  <Attachment Type="CA_BONE" AName="stow_primary3" Rotation="0.38276491,0.3785536,-0.57750142,-0.61374277" Position="0.047497902,-0.12986082,1.3257637" BoneName="Bip01 Spine2" Flags="0"/>
  <Attachment Type="CA_BONE" AName="weapon" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="weapon_bone" Flags="0"/>
  <Attachment Type="CA_BONE" AName="left_weapon" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="lweapon_bone" Flags="0"/>
  <Attachment Type="CA_BONE" AName="stow_secondary1" Rotation="0.6254915,-0.7800051,0.018463103,0.003374205" Position="0.24373323,0.0025271759,0.87072629" BoneName="bip01 r thigh" Flags="0"/>
  <Attachment Type="CA_BONE" AName="stow_secondary2" Rotation="0.69483107,-0.71157902,-0.0024412421,0.10420641" Position="-0.2018645,0.094815969,0.87086833" BoneName="Bip01 L Thigh" Flags="0"/>
  <Attachment Type="CA_SKIN" AName="body" Binding="objects/characters/raquel/raquel_upperbody.skin" Flags="0"/>
  <Attachment Type="CA_SKIN" AName="jacket" Binding="objects/characters/raquel/raquel_torso.skin" Flags="0"/>
  <Attachment Type="CA_SKIN" AName="legs" Binding="objects/characters/raquel/raquel_legs.skin" Flags="0"/>
  <Attachment Type="CA_SKIN" AName="eyes" Binding="objects/characters/raquel/raquel_eyes_ingame.skin" Flags="16"/>
  <Attachment Type="CA_SKIN" AName="eyelashes" Binding="objects/characters/raquel/raquel_eyes_details_ingame.skin" Flags="16"/>
  <Attachment Type="CA_SKIN" AName="eye_ao" Binding="objects/characters/raquel/raquel_eyeoverlay_ingame.skin" Flags="16"/>
  <Attachment Type="CA_SKIN" AName="head" Binding="objects/characters/raquel/raquel_head_ingame.skin" Material="Objects/Characters/raquel/raquel_head.mtl" Flags="0"/>
  <Attachment Type="CA_SKIN" AName="hair" Binding="objects/characters/raquel/raquel_hair.skin" Flags="0"/>
  <Attachment Type="CA_SKIN" AName="teeth" Binding="Objects/Characters/raquel/raquel_teeth.skin" Material="Objects/characters/raquel/raquel_teeth.mtl" Flags="16"/>
  <Attachment Type="CA_BONE" AName="sjnt_l_breast" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_l_breast_00" SA_SpringType="4" SA_FPS="30" SA_Radius="0.021" SA_ScaleZN="0.1" SA_Redirect="1" SA_Damping="6" SA_Stiffness="100" SA_StiffnessTarget="0,0,0.079999998" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_r_breast" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_r_breast_00" SA_SpringType="4" SA_FPS="30" SA_Radius="0.021" SA_ScaleZN="0.1" SA_Redirect="1" SA_Damping="6" SA_Stiffness="100" SA_StiffnessTarget="0,0,0.079999998" SA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_g_00" RelRotation="0.99802667,1.1920945e-07,1.6391299e-07,0.062790617" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_g_00" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="7" PA_Redirect="1" PA_Damping="3" PA_Stiffness="15" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_d_00" RelRotation="0.99802667,1.1920945e-07,1.6391299e-07,0.062790617" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_d_00" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="2" PA_Stiffness="15" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_f_00" RelRotation="0.99802667,1.1920943e-07,1.6391296e-07,0.06279061" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_f_00" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="3" PA_Stiffness="15" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_e_00" RelRotation="0.99802667,1.1920945e-07,1.6391299e-07,0.062790617" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_e_00" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="2" PA_Stiffness="15" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_b_00" RelRotation="0.99802667,1.1920943e-07,1.6391296e-07,0.06279061" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_b_00" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="2" PA_Stiffness="10" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_c_00" RelRotation="0.99802667,1.192094e-07,1.6391293e-07,0.062790595" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_c_00" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="2" PA_Stiffness="15" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_a_00" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_a_00" PA_PendulumType="1" PA_FPS="30" PA_Redirect="1" PA_Damping="2" PA_Stiffness="30" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_a_01" RelRotation="0.87630671,1.8775498e-06,-8.7917016e-07,0.48175359" RelPosition="-1.4901161e-08,0,0" BoneName="Bip01_sjnt_hair_a_01" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="30" PA_Redirect="1" PA_Damping="3" PA_Stiffness="20" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_a_02" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_a_02" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="3" PA_Stiffness="15" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_hair_a_03" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_hair_a_03" PA_PendulumType="1" PA_FPS="30" PA_MaxAngle="20" PA_Redirect="1" PA_Damping="2" PA_Stiffness="5" PA_SimulationAxis="0,0.1,0" PA_CapsuleX="0.02" PA_CapsuleY="0.0049999999" PA_ProjectionType="1" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_zipper" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_zipper_00" PA_PendulumType="2" PA_MaxAngle="15" PA_HRotation="90" PA_Redirect="1" PA_Damping="5" PA_Stiffness="5" PA_SimulationAxis="0,0.1,0" PA_Proxy00="aprox_head" Flags="0"/>
  <Attachment Type="CA_BONE" AName="sjnt_holster" RelRotation="1,0,0,0" RelPosition="0,0,0" BoneName="Bip01_sjnt_holster_00" PA_PendulumType="1" PA_Redirect="1" PA_Damping="5" PA_Stiffness="15" PA_SimulationAxis="0,0.5,0" PA_CapsuleX="0.2" PA_CapsuleY="0.050000001" PA_ProjectionType="1" PA_Proxy00="aprox_spine1" Flags="0"/>
  <Attachment Type="CA_PROX" AName="aprox_spine1" RelRotation="0.99999994,0,0,0" RelPosition="0,0.020731032,-1.1920929e-07" BoneName="Bip01 Spine1" ProxyParams="0.045000002,0,0,0.12" ProxyPurpose="0"/>
  <Attachment Type="CA_PROX" AName="aprox_head" RelRotation="0.99999994,0,0,0" RelPosition="0.049869061,0.031845614,5.9604645e-07" BoneName="Bip01 Head" ProxyParams="0.035,0.0099999998,0,0.059999999" ProxyPurpose="0"/>
  <Attachment Type="CA_PROX" AName="aprox_neck" RelRotation="0.99556196,-7.450582e-08,-2.6645353e-15,-0.094108157" RelPosition="0.046000838,2.9802322e-08,-3.5762787e-07" BoneName="Bip01 Neck" ProxyParams="0.045000002,0,0,0.050000001" ProxyPurpose="0"/>
 </AttachmentList>
</CharacterDefinition>
