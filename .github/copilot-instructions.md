# 文言补缀

文言补缀者，《冥勒》（Inscryption）及诸补缀之文言之补也。今汝当通力制之，以先秦词、句式为优、先，句读则因现代白话之国标，如`，`、`。`、`、`、`“”`者。下为要略。

## 现代白话之原文

`.knowledge/ChineseSimplified.bytes`乃《冥勒》之现代白话之全原文，贮英、中之对照。汝当徐徐阅之，逐行译之。汝当计划以分立，毋单口吞象，译若干，复再译以若干，以此至毕。

## 字典

`.knowledge/zi`存诸字之典以`.json`。`/yi/kv/dict/《康熙字典》`、`/yi/kv/dict/漢語多功能字庫`、`/yi/kv/origin`、`/yi/kv/swjz`、`/yi/nodes`之处为诸字义也。

汝当通读其字义，用甲金文之义为先，即甲骨文、金文之含义也，然后秦汉。若多字皆具应许之义，择先具词义者，即择甲金文乃至本义为此义者为优。若同字多字形之变，择最常见者，择简体字形者也。

全文通约：第一人称：主格：余；宾格：我；属格：朕。第二人称：主格：汝；宾格：尔；属格：乃。第三人称：属格：厥。

术语表：`.knowledge\glossary.csv`乃术语表也，存文件名以Hex非Dec。当每译之，先寻术语，如得寻，遵之；如不得寻，习典，然后总结此行之术语，并更表以新。为保全文之一致，总结以激进。

汝每译一行，必习典为先，然后译之。例：

```
GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_705_M;You are lacking sacrifices for that creature.;你没有足够祭品来使用这个造物。
```

ID：GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_705_M

英吉利语：You are lacking sacrifices for that creature.

现代白话：你没有足够祭品来使用这个造物。

通约：you/你->汝。

寻术语：sacrifice/祭品->牺牲。

习典：lack->乏、𠓟、欠、短；乏乃甲金文本义，𠓟乃乏之异体，欠等非本义，后起义，去乏、𠓟中常见乏。亦以先秦文法，或用“不足”，自行衡量。creature->...

总结术语：creature/造物，寻其典义，更新记录之于术语表。

译文：汝...

撰写译之代码：于`ClassicChineseLanguagePack.cs`之类`InscryptionVanilla`之函式`RegisterTranslations`，写行`ClassicChineseLanguagePackPlugin.Translate(ClassicChineseLanguagePackPlugin.GUID, "GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_705_M", "You are lacking sacrifices for that creature.", "汝...", Language.ChineseSimplified);`。

