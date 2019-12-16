QUEST_DREADBIG = {
	title = 'IDS_PROPQUEST_INC_001208',
	character = 'MaFl_Gergantes',
	start_requirements = {
		min_level = 20,
		max_level = 29,
		job = { 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN' },
	},
	rewards = {
		gold = 0,
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_001209',
			'IDS_PROPQUEST_INC_001210',
			'IDS_PROPQUEST_INC_001211',
			'IDS_PROPQUEST_INC_001212',
			'IDS_PROPQUEST_INC_001213',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_001214',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_001215',
		},
		completed = {
			'IDS_PROPQUEST_INC_001216',
			'IDS_PROPQUEST_INC_001217',
			'IDS_PROPQUEST_INC_001218',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_001219',
		},
	}
}